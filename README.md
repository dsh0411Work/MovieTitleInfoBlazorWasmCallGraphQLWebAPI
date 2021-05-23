# Blazor Web Assembly Single Page Application:


- Project Name:  TitleInfoClient
- Project Description:  SPA Web Application that calls a GraphQL Web API to get Movie Title Information  
- Project Dependencies:
  - Required Framework:  .NET 5 
  
  - Requires the following NuGet Packages:
    - Microsoft.AspNetCore.Components.WebAssembly Version 5.0.6
    - Microsoft.AspNetCore.Components.WebAssembly.DevServer Version 5.0.6
    - Microsoft.Extensions.Http Version 5.0.0
    - System.Net.Http.Json Version 5.0.0

- 3rd Party Libraries:
  - [JQuery DataTables](https://datatables.net/forums/discussion/56389/datatables-with-blazor) 
    - Easily integrated it to the Blazor app and the table is fully SEARCHABLE, and has pagination and sorting out of the box.


- How to run:

  - Open the folder in Visual Studio Code
  - Click “Yes” to add dependencies
  - Open up a Terminal and run this command:  dotnet run
  - Open up Google Chrome or Edge:  <http://localhost:5002>  (I modified the LaunchSettings.json to have it point to a different port than 5001 as the web api is using it)

- How To Debug:

  - You’ll need to use CHROME or EDGE as currently FireFox does not support the (Shift+Alt+D)
  - Run the following command:  dotnet run –configuration debug
  - Open up Google Chrome or Edge:  <http://localhost:5002>
  - Press F12
  - Press Shift + Alt+D
  - A new Tab will open, copy the command provided and run it.
  - Another browser window will pop up 
  - Press F12 
  - Press Shift+Alt+D again
  - In the Developer tools click on the “Sources” tab, you’ll see the wasm folder (expand and you’ll see the C# files as if you were in visual studio)


