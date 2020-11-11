# XYZ Automation
This project contains automated integration tests for XYZ project

## Automation Approach
Web automation in XYZ project relies heavily on Selenium library(because it free,open source, and got best community support). 
When a automation script is developed using Selenium, we should make sure that the script is maintenable, readable , and stable.

As we all know, selenium uses 'locators' to identify and intereact with UI controls(textbox,radio button , link , button etc.) in a web user interface. There are different type of locators supported by selenium.
Most common locator types used in selenium are :
* Id
* Xpath
* Css Selector
* Tag Name
* Link Text

When we instruct selenium to find a UI control and interact with it , we need to provide the locator of the UI control also , so that selenium can look up and find it from the web page, and this is a must do activity for selenium interaction.

Now, let's take an example :
Application A under test has 5 pages , and each page has 50 UI controls , and UI controls are 5 different types
* Page 1 - 30 UI Controls ( 5 Textbox , 5 Buttons , 5 Dropdowns , 5 Radio buttons , 5 checkboxes , 5 auto suggest boxes)
* Page 2 - 30 UI Controls ( 5 Textbox , 5 Buttons , 5 Dropdowns , 5 Radio buttons , 5 checkboxes , 5 auto suggest boxes)
* Page 3 - 30 UI Controls ( 5 Textbox , 5 Buttons , 5 Dropdowns , 5 Radio buttons , 5 checkboxes , 5 auto suggest boxes)
* Page 4 - 30 UI Controls ( 5 Textbox , 5 Buttons , 5 Dropdowns , 5 Radio buttons , 5 checkboxes , 5 auto suggest boxes)
* Page 5 - 30 UI Controls ( 5 Textbox , 5 Buttons , 5 Dropdowns , 5 Radio buttons , 5 checkboxes , 5 auto suggest boxes)

As a tester, when you automate Application A , you will end up writing **30 x  5 = 150 Locators !!! **

Writing 150 locators should be last option! Why ?
First , think about developer(s) who built this application. Do you think a developer has designed each and every control












