# Wiki-Game
This Application is a bot that crawls Wikipedia sites.

If you plan to use this tool excessively, you should add some contact information in the user agent ```string _userAgent```
to enable the Wikipedia staff to contact you, in case a problem with your request rate appears.
_

---
Each thread is executing prallel request to the Wikipedia servers.
On high thread counts, it's possible that the request is seen as possible Dos-attack and will be blocked.

The critical number on which the programm starts to get blocked, is ***between 8-10 Threads***</br>
and is also depending on the duration of the request.

If you're blocked out constantly, you can disable the Api with a checkbox, of course with huge performance loss.

It is recommend, to reduce the thread count with the recursion depth, to prevent this lock.

---

The Non-Designer [Code](WikiGui/Form1.cs), can be found in [WikiGui/Form1.cs](WikiGui/Form1.cs).<br/>
Compiled executables of Release-Versions are in this [Folder](ReleasedVersions)

---

The programm tries to find the shortest way from a given start page, to a given target page,
by downloading the html-Files and rekursively searching any possibility.

It is following more or less the rules of the [Wiki-Game](https://en.wikipedia.org/wiki/Wikipedia:Wiki_Game),
but it allows Dates (specifid Days and months) and locations, while Years can be filtered as you desire.
Of course the rule, to not use a bot, is broken.

The filter, which filters non-article links, may not work correctly on other languages than German,</br>
due the lack of naming conventions for special sites like the Mainpage.

---

The nature of this method requires high amounts of network traffic (about 10 MBit/s per thread),
 so ***be carefull with limited internet contracts***.
 
 
 As it started as a two method console project, the code is a bit messy...
