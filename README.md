Scheduler 1.1.3
=========
Assists in scheduling and keeping track of events/appointments/meetings.
I made this because programs such as google calendar fail to display upcoming events in such a way where it is easy to plan when to do homework/projects/whatever.

Event data is stored in events.json which is stored in the binary's directory.

![](http://i.imgur.com/DByEbWg.png)


When an event is less than a day away, the program will let you know with a desktop notification. If you aren't at the computer once the event is less than a day away, the program will wait until you return before letting you know about the impending event.
![](http://i.imgur.com/cqcO2Gm.png)



Changelog
=========

1.1.3:

-Fixing an exception that may occur after refocusing the scheduler after a recent event has expired

1.1.2:

-Event panel is now focused on startup so you can use the scroll wheel to scroll through dates immediately.

-Horizontal scrollbar doesn't show up when you have long dates involved anymore.

-Editing an event, then clicking a different event will now correctly cancel event editing fields

-Fixed bug where editing a date twice wouldn't work correctly

-Fixed a bug where scheduler items would appear out of order after an edit

1.1.1:

-Fixed bug where could not change daylight to PM in the "Add event" dialogue.

1.1.0:

-Reorganized UI to allow easier deletion of events

-"Add event" dialog moved to menu item

-Implemented event editing

-Fixed bug with events displaying out of order

-Fixed bug where deleting an event would delete all other events with the same description

1.0.0:

-Release

contact@bsamuels.net