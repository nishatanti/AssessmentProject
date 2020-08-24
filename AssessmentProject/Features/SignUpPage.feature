Feature: SignUpPage
	

Scenario: Verify the functionality of English language dropdown
	Given User is on Signup Page
	When  Click on language dropdown
	And   Select English language from dropdown
	Then  All the details of page comes in English language

Scenario: Verify the functionality of Dutch language dropdown
	Given User is on Signup Page
	When  Click on language dropdown
	And   Select Dutch language from dropdown
	Then  All the details of page comes in dutch language

Scenario: Verify the functionality jabatalks signup 
	Given User is on Signup Page
	And   Select language from dropdown
	When  Enter name, organisation and email address	
	And   Select I agree option
	And   Click on signup button
	Then  A validation message of welcome appear on the page

Scenario: Verify the jabatalks mail inside mailbox
   Given  User is on yahoomail page
   When   Enter username and password
   And    Click on next button
   And    Userlogged in sucessfully   
   Then   JabaTalks mail should appear inside the inbox

              