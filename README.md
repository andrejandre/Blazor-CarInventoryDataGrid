# Blazor-CarInventoryDataGrid
Utilizing Radzen and Blazor to build a basic CRUD application representing the management of an inventory of cars at a dealership.

This was built using the principles of clean architecture as it applies to the onion architecture, top-down dependency management, and modular monolith applications.

Blazor applications built in this fashion are good candidates for reusable libraries, developing in team settings, and increasing testability and reusability of code. 


# Important
- Right-click on `wwwroot` in VisualStudio and add the bootstrap libraries via `cdnjs`. This will enable the necessary frontend capabilities.
- Add the necessary nuget packages, which include Radzen.
- Make sure you utilize **Sql Server Express** and create a Cars database, and a table, which aligns with the `CarEntity` found in the `Domain` folder.
