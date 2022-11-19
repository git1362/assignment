# Project Structure
- SomeonesToDoListApp.Domain: includes domain logic 
- SomonesToDoListApp.Infrastrcuture: includes persistence code
- SomonesToDoListApp.Services: includes orchestration logic
- SomonesToDoListApp.API: include API codes that can be called by frontend app
- SomeonesToDoListApp.Web: include frontend code which mostly written with React.

# SomonesToDoListApp.Services
### Features Folder
this folder include application' features. It's using mediator pattern and mostly organized by Vertical architecture mindset, each request considered as a feature.

# How to Run
### SomonesToDoListApp.API
you can either use 
    
    SomonesToDoListApp.API > dotnet run
or open visual studio and click Run

### SomeonesToDoListApp.Web
you can use visual studio to run application or in command promopt use
below commands

    SomeonesToDoListApp.Web> npm run start
    