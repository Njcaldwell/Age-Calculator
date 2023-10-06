import random
from datetime import date

today = date.today()
date = today.strftime("%Y")
print(date)
name = input("What is your name? ")



Birth_Year = input("What year were you born? ")
User_Birth_Year = int(Birth_Year)

Age = - User_Birth_Year

print(name + " you are " + str(Age))

while True:
    User_Option = input("Would you like to know how old you would be in a future year? yes/no ")
    
    if User_Option == "yes":
        User_Future_Year = input("What year would you like to know how old you would be? ")
        Future_Year = int(User_Future_Year)
        User_Future_Age = Future_Year - User_Birth_Year
        print("You would be "+ User_Future_Age)
   
    elif User_Option == "no":
            break
    else:
        continue