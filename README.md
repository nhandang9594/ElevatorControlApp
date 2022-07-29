# ElevatorControlApp

# How to run the app:
+ Open Visual Studio Code.
+ Choose 'Clone Git Repository' option on the main menu.
+ Copy and paste the https url under 'Code' (green button) --> HTTPS --> copy the URL in GitHub repository.
+ Press enter and choose the local repository location.
+ Open solution by using Visual Studio.
+ Run Kestrel server (by default on both Mac and Windows user).

# How to test features:
+ After the initial run of Swagger, there will be 2 group of API calls: Elevator and Person.
+ Use /Elevator/next (GET method) to get the next floor for an elevator car.
+ Use /Elevator/all (GET method) to get all the floors that the elevator car's current passengers are servicing.
+ Use /Person/next/{nextFloor} (GET method) to request the elevator car to bring a person to a destinated floor.
+ Use /Person/all/{currentFloor}/{nextFloor} (GET method) to request an elevator to a person's current floor.
