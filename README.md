# AssessmentProject
This project is created in specflow framework using NUnit test project (.Net Core) template

There are four main folders
Features
Features folder comes up with feature.cs file  
This file contains all the scenarios sign up page(sign up testing is the requirement)

Step Definition
This folder contains SignUpSteps.cs file
This file contains all the steps of feature file scenarios

Page Object
This folder contains SignUpRepo.cs file
This file contains all the all the locators and their actions of sign up web page 
which we are going to use in signup scenarios
and created individual method for each web element of signup page

Utility
This folder contains two file Hooks1.cs and support.cs
Hooks1.cs -> Here we are intialising the chromebrowser in before scenario
and closing the browser in after scenario
And using the context injection feature for representing the shared data
Support.cs-> here we are declaring methods for waits and screeshot

Steps to run the scenarios of feature file
1) Goto  Menu bar -> click Build -> click on build solution -> Build sucessfull message appears below the output window
2) Now goto Menu bar again -> click on Test -> Click on Test Explorer-> It will will show all the scenarios in a hierarchy formate
3) Now right click on any scenario from the hierachy of test explorer -> click on Run option -> It will run your scenario
4) If your test(scenario) run sucessfully it will show a green check mark
5) If the test fails ti will show a red cross mark.
