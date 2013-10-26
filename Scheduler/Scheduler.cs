#region

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

#endregion

namespace Scheduler{
    public class Scheduler{
        const string _savedEventsPath = "events.json";

        readonly List<Event> _events;

        public Scheduler(){
            if (File.Exists(_savedEventsPath)) {
                _events = LoadEvents();
            }
            else{
                _events = new List<Event>();
            }
        }

        public void RefreshActiveEvents(){
            foreach (var e in _events){
                if (e.HasPassed)
                    continue;

                var now = DateTime.Now;
                if (e.EventDate < now){
                    e.HasPassed = true;
                }
            }
        }

        public List<DisplayEvent> GetActiveEvents(){
            var activeEvents = _events.Where(e => !e.HasPassed && !e.IsCancelled).ToArray();
            var displayEvents = new List<DisplayEvent>(activeEvents.Length);
            foreach (var @event in activeEvents){
                var displayEvent = new DisplayEvent();
                displayEvent.Description = @event.Description;
                var time = DateTime.ParseExact(@event.EventDate.TimeOfDay.ToString(), "HH:mm:ss", null).ToString("hh:mm tt");
                displayEvent.Time = time;
                var date = @event.EventDate.Month + "/" + @event.EventDate.Day + "/" + @event.EventDate.Year;
                displayEvent.Date = date;

                var timeUntil = @event.EventDate - DateTime.Now;
                var timeUntilStr = timeUntil.Days + "d " + timeUntil.Hours + "h " + timeUntil.Minutes + "m " + timeUntil.Seconds + "s";
                displayEvent.TimeUntil = timeUntilStr;
                displayEvent.EventDateTime = @event.EventDate;

                displayEvents.Add(displayEvent);
            }
            return displayEvents;
        }

        public void AddEvent(string description, DateTime timeAt){
            if (timeAt < DateTime.Now){
                throw new Exception("you just did something stupid and im too lazy to catch it");
            }
            var newEvent = new Event();
            newEvent.Description = description;
            newEvent.EventDate = timeAt;
            newEvent.HasPassed = false;
            newEvent.IsCancelled = false;
            _events.Add(newEvent);
            SaveEvents();
        }

        public void CancelEvent(string description, DateTime time){
            bool eventFound = false;
            foreach (var @event in _events){
                if (@event.Description.Equals(description) && @event.EventDate == time){
                    @event.IsCancelled = true;
                    eventFound = true;
                }
            }
            Debug.Assert(eventFound);
            SaveEvents();
        }

        public void EditEvent(string curDescription, DateTime curTime, string newDescription, DateTime newTime){
            bool eventFound = false;
            foreach (var @event in _events) {
                if (@event.Description.Equals(curDescription) && @event.EventDate == curTime) {
                    @event.Description = newDescription;
                    @event.EventDate = newTime;
                    eventFound = true;
                }
            }
            Debug.Assert(eventFound);
            SaveEvents();
        }

        void SaveEvents(){
            var sw = new StreamWriter(_savedEventsPath);
            var serialized = JsonConvert.SerializeObject(_events, Formatting.Indented);
            sw.Write(serialized);
            sw.Close();
        }

        List<Event> LoadEvents(){
            var sr = new StreamReader(_savedEventsPath);
            var eventDataStr = sr.ReadToEnd();
            sr.Close();

            var savedEvents = JsonConvert.DeserializeObject<List<Event>>(eventDataStr);
            if (savedEvents != null){
                return savedEvents;
            }
            return new List<Event>();
        }
    }
}