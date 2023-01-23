# Technical assignment based around Hudl login page functionality

# Project Description:
This project consist of a variety of automated test using Selenium that test the funtionality of various Log In page componenets.  This project was written in C#, which I have the most familiarity with, but could be written in variety of languages.  The estimation time for the assignment was around two hours, so I stuck as closely to that estimate as I could.
# Potential Future Features:
The tests were fairly simple and designed to succeed, that said, as a bit of a failsafe the addition of shorter timeouts would be one of my first goals.  Currently, some of the tests that rely on finding and then interacting with certain elements would fail if said elements couldn't be found.  If a test is going to fail, I would prefer it do so quickly.  The next feauture I might implement would be a more intelligent way to handle javascript loads.  Currently the tests use the typical thread.sleep(x) but I would like for the test to be a bit more intelligent, perhaps a loop that would attempt to detect those elements.  If the test was able to detect the elements it was looking for within x tries then it would interact with them, otherwise the test would fail.
# How to use this solution:
Pull these files onto your local machine and place them into whatever folder you might like.
