# AssignmentTwo
This is a mobile app for the pet-clinic
21F_Assignemnt-02 

21F_Assignemnt-02 
Objective: 
The objective of this assignment is to create a multiple page App with local Database and three Main 
functionalities: 
✓ User Login-Registration 
✓ Vet Registration-Display 
✓ Pet Registration-Display 
 
 
Outline of the Assignment: 
Login-Registration Page: 
✓ This page will be the first page of your app. You will enter username and password and click the 
login button.  
✓ If you are not already registered,  click the Register button to go to a new page to register. Here 
you will enter username, password (at least 10 character/digits) along with firstname, lastname, 
phone number and email address.   
✓ Once you have completed registration, you will come back to the login page  
✓ You will login with your username and password only. 
 
 
 
 
Home page: 
✓ The home page will contain the Pet clinic logo. 
✓ It will also contain 4 + 1 buttons 
o “Vet Registration” (take you to the Vet Registration page)  
o “Vet List” (take you to the Vet display page) 
o “Pet Registration” (take you to the Pet Registration page) 
o “Pet Display” (take you to the Pet display page) 
o “Logout” (take you to the Login page) 
Vet-Registration and Vet Display: 
✓ When you click on the “Vet Registration” button,  
o you will navigate to the “Vet Registration” page 
✓ You will enter VetID, Lastname, FirstName, email, telephone#, specialization etc 
✓ Once registered, it will go back to the main page 
✓  
✓ Upon clicking the “Vet List” button,  
o you will navigate to the “Vet List” page 
o a list will be populated from the existing Database 
o If no item is in the Database, show an alert message    
o Use Collection view (to display list of items form the Database) 
o <CollectionView.ItemTemplate> and <DataTemplate> 
o Use of Data binding (at least inside DataTemplate) 
 
Pet-Registration and Pet Display: 
✓ When you click on the “Pet Registration” button,  
o you will navigate to the “Pet Registration” page 
✓ You will enter PetID, PetName, PetType any other relevant information from the Petclinic 
project  
✓ Once registered, it will go back to the main page 
✓  
✓ Upon clicking the “Pet List” button,  
o you will navigate to the “Pet List” page 
o a list will be populated from the existing Database 
o If no item is in the Database, show an alert message    
o Use Collection view (to display list of items form the Database) 
o <CollectionView.ItemTemplate> and <DataTemplate> 
o Use of Data binding (at least inside DataTemplate) 
 
  
Use of Separate Classes and Data binding: 
✓ You will be using appropriate Model classes  
✓ One class for database operation 
✓ Additional class/classes if needed 
✓  
✓ You will be using Data binding 
✓ your class needs to provide the proper property changed notifications. 
✓ You need to implement INotifyPropertyChanged you need to declare the PropertyChanged 
event and create the OnPropertyChanged method. Then for each property you want change 
notifications for, you call OnPropertyChanged whenever the property is updated.
