# Technical assignment based around Hudl login page functionality

# Project Description:
This project consist of a variety of automated tests using Selenium that test the funtionality of various Log In page components.  This project was written in C#, which I have the most familiarity with, but could be written in variety of languages.  The estimation time for the assignment was around two hours, so I stuck as closely to that estimate as I could.
# Potential Future Features:
The tests were fairly simple and designed to succeed, that said, as a bit of a failsafe the addition of shorter timeouts would be one of my first goals.  Currently, some of the tests that rely on finding and then interacting with certain elements would fail if said elements couldn't be found.  If a test is going to fail, I would prefer it do so quickly.  The next feauture I might implement would be a more intelligent way to handle javascript loads.  Currently the tests use the typical thread.sleep(x) but I would like for the test to be more adaptive, perhaps a loop that would attempt to detect those elements.  If the test was able to detect the elements it was looking for within x tries then it would interact with them, otherwise the test would fail. Another functionality I would add would be new functionlity for current tests based around alternative browsers and mobile use.  Currently the tests are only set-up to test Chrome on desktop.

One last think I would do, as the project got bigger, would be to create separate files for tests and helper methods.
# How to use this solution:
This solution was created in Visual Studio and that is how I would recommend running them.

Pull these files onto your local machine and place them into whatever folder you might like, with an address such as: C:\Users\YourUser\Desktop\ProjectFolderName


The chromedriver.exe file should be place in a separate folder with the address:  C:\Users\YourUser\Desktop\ProjectFolderName\WebDrivers\Chrome

In the UnitTest.cs file on line 11, the private string DriverPath should be updated to reflect the new path of the chromedriver.exe file:  @"C:\Users\YourUser\Desktop\ProjectFolderName\WebDrivers\Chrome"


Next, in the UnitTest.cs file, the UserName and UserPassword strings on lines 36 and 37 will need to be updated with whatever you want to use.
