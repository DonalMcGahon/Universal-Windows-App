# Mobile Applications Development
# Year 4, BSc (hons) in Software Development

## Windows Universal App Description
* This Windows Universal App is called Medicine Tracker.
* The idea behind the application is to allow users of the app to keep track of when they have to take their medication or when to give medication to others.
* The user is greeted with a login page once they open the app. They will have to navigate to the register page and enter a username, password and email (optional) to register with the app.
* They then can use those details to login.
* The user can enter details about medication for example who's it for, time to be taken and date to be taken.
* This information is stored on the cloud platform Azure.
* The user can navigate to medication page by using the hambuger view and there will be all the information they entered.
* Once they have taken or given the medication, they can tick it off by ticking the checkbox beside each entry.
* The user can also add appointments to their calender on their machine.
* They can enter an appointment name, location, details, time and date and all this information is stored onto there calendar on the machine they are using.

# User Guide
When you launch the app you are firstly greeted with a Login page, where registered users of the app can Login with their credentials. To register with the app is very simple.

### Registering account with app:

To register an account with the app you simply press the register button on the Login page. You are then brought to the Registration page, where you enter your Username, Password and Email address and click register when finished.
You will then be brought back to the Login page.

![reg](https://user-images.githubusercontent.com/14197773/32846297-c88647b0-ca1e-11e7-976a-4332770dc196.png)

### Login to the app:

With the credentials you entered when registering with the app, you can now use those credentials to log in to the app.
Enter your username and password and click the Log In button.
You are successfully logged in.

![login](https://user-images.githubusercontent.com/14197773/32846313-d48e34be-ca1e-11e7-8d9e-1e474fe9de12.png)

### Medicine Tracker Page

On this page you can enter details about who the medication is for, the name of the medication, dosage, time and date to be taken.
Once all entered press the add button and all information will be stored on the medication list page.

![medentry](https://user-images.githubusercontent.com/14197773/32846329-e202c7b8-ca1e-11e7-92bf-822e560dd71f.png)

### Medication List Page

On this page the list of all information the user has entered will be displayed.
This user can stroll up and down the information and use the checkboxes to get rid of any entry that has been completed.

![medlist](https://user-images.githubusercontent.com/14197773/32846351-f0f93fb8-ca1e-11e7-9079-1ed8d0b0e3cf.png)

### Appointment Page

This page allows the user to enter an appointment to the calendar app of their operating system.
To do this, the user enters an appointment name, location, details, time, date and duration and click the Add button.
This will create the appointment in the Calendar app and the user will have the choice to Accept it or Cancel it.
The user can press the Calendar button which will bring them to their Calendar app.
Below is an example of an appointment.

![appoint](https://user-images.githubusercontent.com/14197773/32846369-fad9f842-ca1e-11e7-8c54-ea94a22fc991.png)
![appointaccept](https://user-images.githubusercontent.com/14197773/32846386-0225e412-ca1f-11e7-9fd8-0eb51734d6a2.png)
![appointmentcal](https://user-images.githubusercontent.com/14197773/32846399-095bd66a-ca1f-11e7-8480-467473cff4ed.png)


### Sign Out

The user can sign out of the app at any time by using the sign out option in the hamburger view as seen below.

![hamburgerview](https://user-images.githubusercontent.com/14197773/32846412-1795c394-ca1f-11e7-8ff2-fcfba782cdaa.png)

## Multilingual

My app is Multilingual, which means it is fully functional in many languages. The languages it is able to work in are English, French, Polish, German and Spanish.
Fot the app to work in any of these all you have to do is have your operating systems default language as one of those languages.
Below is an example of the application running in Spanish.

![spanish](https://user-images.githubusercontent.com/14197773/32846879-542d01fe-ca20-11e7-9464-f873dd795971.png)

## Button Style

For the button in my project I followed the following [tutorial]().
The buttons in my app give the effect as if they are being pressed down.

## Azure

To store all the user information about the medication, I used the cloud service called Azure.
If you want to learn more about Azure click [here](https://azure.microsoft.com/en-us/)

## SQLite Database

For the users login credentials I used a SQLite database to store them.

![user database](https://cloud.githubusercontent.com/assets/14197773/25071507/d2dcf890-22b1-11e7-9f29-b41c04c46744.png)

The above is an example of the database used to store user log in information. The UserName is the username the user entered, in this case the username is "donal123".
The Password is the password the user entered, in this case again it is "donal123".
Email represents the email associated with the user, the user entered "donal123@gmail.com".

## References