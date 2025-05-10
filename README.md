# hemtest - kodprov

# purpose
Creating a code test desired by the manager.

# Information about the program
This is a ASP.NET Core Web API .NET8 LTS that lets the user to enter different words and then the program takes out the most common words and shows a counter on how many time it has been shown.

# getting started
You need to have an IDE like Visual Studio installed - link below:
https://visualstudio.microsoft.com/downloads/

# how to run the program
I suggest that you already have Visual Studio installed.
Click on my repository called: hemtest and then click on the <> Code button. See image below:
![image](https://github.com/user-attachments/assets/421e965b-8656-48a6-8f46-2205f10e24a0)

Wait for Visual Studio to open up and load in the solution.
Once Visual Studio is up and ready. You can click on the Play button, see image below:
![image](https://github.com/user-attachments/assets/25918909-60d3-4fb5-be15-9c13a135e6a1)

#swaggerUI will show up
Click on the POST bar, it a green bar and inside of the green bar you will see: POST / api /FrequentWords.
Once you see green bar opens up, you can see a black box where it says: "string"
Click first on the Try it out, a grey button to the top right inside of the green box.
![image](https://github.com/user-attachments/assets/d8852a05-2ab9-4d28-a3bb-dfbb8a2ced44)


The black box will switch to white and you will be able to change the word.
![image](https://github.com/user-attachments/assets/e642a805-70e1-4b0b-ad19-23f345650048)


## Do not remove " " - just edit - " your text "
## Click on Execute and you will see if the Code box returns a 200, then it is a success. See your counts!
![image](https://github.com/user-attachments/assets/32ea4ffa-e4b7-4c2e-873d-2a2d9a3e54f2)

## Important
If you get an error like this: ![image](https://github.com/user-attachments/assets/79ddd1c4-3459-4605-aa47-0f58ac95091f)
Then you need to put \n before your text if it comes from example a new letter. the JSON does not like the "enter" so put a " \n " on all the "enters" then it will work.
