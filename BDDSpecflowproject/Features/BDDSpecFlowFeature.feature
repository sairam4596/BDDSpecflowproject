Feature: BDDSpecFlowFeature
	Automate the website (BigSmall.in)

	Background:website intialisation
	    Given intialize the browser
		And navigate to the url

    Scenario:get the title of the homepage
	 Given i am in homepage
	 Then get the title of the homepage

	 Scenario Outline: login with valid credential
	 Given  I click on signin
	 And enter the email-id and password
	 Then click on the Signin button

	 Examples: 
	 | email                    | password    |
	 | sairamyadav179@gmail.com | Sairam@4596 | 

     Scenario Outline: login with invalid user data
     Given I click on signin
	  And enter the invalid email-id and password
	 Then click on the Signin button and screenshot of invalid user

	 Examples: 
	 | email                    | password    |
	 | sairamyadav1791@gmail.com | Sairam@45961 | 

     Scenario: create account
	 Given  I click on signin
     And   click on create account 
	 And enter  the firstname ,lastname,email and password
	 When click on create button
	 Then  login to the new create account

	 Scenario: signin with google    
	  Given  I click on signin
	  And click on the google link
	  When enter  the value on the email 
	  Then take the screenshot

	  Scenario: search for item 
	   Given i am in homepage 
	   And enter the item in the search bar 
	   Then take the screenshot of result

	   Scenario: Add the gifts card 
	   Given i am in homepage 
	   And click on the gifts card
	   When click on the add to card
	   Then take the screenshot of card

	   Scenario: check the cart
	    Given i am in homepage 
		And click on the cart
		Then take the screenshot of cart item
	 
	  Scenario: pincode adddress vertify
	   Given i am in homepage
	   And click on the gifts card
	   When enter the pin code and click on check button
	   Then take screenshot of address

	   Scenario: check the wish list
	    Given i am in homepage
		And Click on the wish list
		Then take screenshot of wish list page

		Scenario: check on the birthday gift
		 Given i am in homepage
		 And click on the birthday gift
		 Then take screenshot of birthday gifts

		 Scenario: check on the gifts
		 Given i am in homepage
		 And click on the gifts and click on the click on gift for guys
		 Then take the screenshot of the page