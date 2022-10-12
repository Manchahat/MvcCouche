Student Name : Manchahat Singh Bhangu
Student Id: 0802991
Assignment purpose :  'Product' assignment and investigate this real world object for specific properties, structure and various attributes.
Produce a fictional company name to promote the product, note details of the object and review the architecture of a robust MVC web application
to generate a product catalogue allowing for CRUD operations.

test the application 
Added  a new page in view called aboutus and connected it in the home controller . 
http://localhost:59772/Home/Aboutus
the website is working if i manually type in the browser but not able to find it in navigation 
9:08
finally find out how to navigate it
added a new column for the about us page to show in he navgation 

creating a new class in th model file 
took a long while for adding the data 
i have added 7 properties in the couches file 

Id
Price
Color
Weight
Height 
Design and 
Country Of Origin 

Added a new file in the MvcCoucheContext in data folder and made changes according to the tutorial 

for the next step of registering the database context 
the changes are by default added in the startup file . skipping this step 

made a small change in the startup page for the cofiguration 
added a connection in the app setting page 
adding the scaffolding now 
it took a while and finally completed it

adding seed data 
took a long time writing the values 
i have added 6 values in total fro each property 
9:56

I forgot to added Migration after completing the seed data ..
added migration named Initial create 
and updated the data base 

Changed couple of things in the program for initializing the seed data 
rebuild the application 
Checked the application by running it 
while i m clicking on the MvcCouche Logo it doesnt show me any table created 

Updated the database again 
In the tutorial in the views , they said to change a 
<a> tag and now my application is working 

finally all the data is working 

Updated the about us page for adding more details 

added 4 new values from the website to all 10 values in it 