# MovieTitleInfoBlazorWasmCallGraphQLWebAPI
Simple Blazor Web Assembly App that shows movie info that calls a GraphQL Web API Endpoint



|Database Schema |
| :- |
||




|Solution|
| :- |
||



||
| :- |
||


||
| :- |
||


Graph QL Web API Project:  

- Project Name:  TitleInfoGQL
- Project Description:  GraphQL Web API reads data from SQL Server via Entity Framework Core  
- Project Dependencies:
  - Required Framework:  .NET 5 
  - Requires the following NuGet Packages:

|<p>- <PackageReference Include="GraphQL.Server.Ui.Voyager" Version="5.0.2" /></p><p>- `    `<PackageReference Include="HotChocolate.AspNetCore" Version="11.2.2" /></p><p>- `    `<PackageReference Include="HotChocolate.Data.Entityframework" Version="11.2.2" /></p><p>- `    `<PackageReference Include="Microsoft.EntityframeworkCore.Design" Version="5.0.6"></p><p>- `      `<IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets></p><p>- `      `<PrivateAssets>all</PrivateAssets></p><p>- `    `</PackageReference></p><p>- `    `<PackageReference Include="Microsoft.EntityframeworkCore.SqlServer" Version="5.0.6" /></p>|
| :- |

- Requires the following Tools:

|<p>&emsp;- Entity Framework Core .NET Command-line Tools,  Version 5.0.6</p><p>&emsp;&emsp;- Check to see if you have it via command:  dotnet ef</p><p>&emsp;&emsp;- To install type command:  dotnet tool install --global dotnet-ef</p><p>&emsp;&emsp;- To update type command:  dotnet tool update --global dotnet-ef</p><p>&emsp;- Database First script I ran to automatically create Model classes:  Scaffold-DbContext "Server={ServerName}\{InstanceName};Database=Titles;Trusted\_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer --output-dir Models</p><p>&emsp;&emsp;- IMPORTANT NOTES :  </p><p>&emsp;&emsp;&emsp;- You’ll need to do some tweaking to YOUR DbContext class:</p><p>&emsp;&emsp;&emsp;&emsp;- Remove the empty constructor</p><p>&emsp;&emsp;&emsp;&emsp;- The empty-less constructor remove your type as the Hot Chocolate Framework doesn’t like it and leave just the “DbContextOptions” plain </p>|
| :- |

- How to run:

|<p>&emsp;- Open the folder in Visual Studio Code</p><p>&emsp;- Click “Yes” to add dependencies</p><p>&emsp;- Open up a Terminal and run this command:  dotnet run</p><p>&emsp;- Open up Google Chrome or Edge:  <http://localhost:5000/graphql/>  </p>|
| :- |

- How to debug:

|<p>- Download and install the [Insomnia API](https://insomnia.rest/download) as it is AMAZING and your friend for debugging! </p><p>- In your Startup.cs file do the following:</p><p>&emsp;- In your constructor, in addition to the IConfiguration, also INJECT the IWebHostEnvironment and create your private readonly property for it as well.</p><p>&emsp;- In the ConfigureServices method where you are adding the GraphQLServer, add this to the chain of “services.AddGraphQLServer()” for the Hot Chocolate Framework as it will EXPOSE MORE DETAILS on any exceptions you’re encountering when your environment is set to “IsDevelopment” environment variable:  </p><p>.ModifyRequestOptions(opt => opt.IncludeExceptionDetails = \_env.IsDevelopment());</p>|
| :- |



Testing the GraphQL Web API:

|Here’s how you can use the Insomnia API to test your GraphQL endpoint|
| :- |
||

What is GraphQL?

|<p>- Is A Query & Manipulation language for APIs</p><p>- Is the runtime for fulfilling requests</p><p>- Everything in GraphQL is a POST request</p><p>- They just need ONE endpoint that all end in “/graphql”</p><p>- Was created by Facebook to address both over and under fetching</p><p>&emsp;- No over fetching happens as you can pick only the fields you need and NOT the ENTIRE payload </p><p>&emsp;- No under fetching happens as you can drill down to the children and grab what you need in just ONE request.</p><p>- Open Source hosted by the Linux Foundation;</p><p>It has a Schema that describes the API in full and thus self documenting.</p>|<p>- Is comprised of “Types” which can be any of the following:  </p><p>&emsp;- Query, </p><p>&emsp;- Mutation, </p><p>&emsp;- Subscription, </p><p>&emsp;- Objects, </p><p>&emsp;- Enumeration – list of static values</p><p>&emsp;- Scalar – id, int, string boolean, float </p><p>- Must have a “Root Query Type”</p><p>- Has Resolvers which can do the following: </p><p>&emsp;- return data for a given field (The Hot Chocolate Framework will do the heavy lifting for you)</p><p>&emsp;- Resolve to ANY data source (Database, Microservice, REST API, etc.)</p><p></p>|
| :- | :- |




Blazor Web Assembly Single Page Application:

- Project Name:  TitleInfoClient
- Project Description:  SPA Web Application that calls a GraphQL Web API to get Movie Title Information  
- Project Dependencies:
  - Required Framework:  .NET 5 
  - Requires the following NuGet Packages:

|<p>- <PackageReference Include="Microsoft.AspNetCore.Components.WebAssembly" Version="5.0.6" /></p><p>- `    `<PackageReference Include="Microsoft.AspNetCore.Components.WebAssembly.DevServer" Version="5.0.6" PrivateAssets="all" /></p><p>- `    `<PackageReference Include="Microsoft.Extensions.Http" Version="5.0.0" /></p><p>- `    `<PackageReference Include="System.Net.Http.Json" Version="5.0.0" /></p>|
| :- |

- 3rd Party Libraries:

|<p>&emsp;- [JQuery DataTables](https://datatables.net/forums/discussion/56389/datatables-with-blazor) </p><p>&emsp;&emsp;- Easily integrated it to the Blazor app and the table is fully SEARCHABLE, and has pagination and sorting out of the box.</p>|
| :- |

- How to run:

|<p>&emsp;- Open the folder in Visual Studio Code</p><p>&emsp;- Click “Yes” to add dependencies</p><p>&emsp;- Open up a Terminal and run this command:  dotnet run</p><p>&emsp;- Open up Google Chrome or Edge:  <http://localhost:5002>  (I modified the LaunchSettings.json to have it point to a different port than 5001 as the web api is using it)</p>|
| :- |

- How To Debug:

|<p>&emsp;- You’ll need to use CHROME or EDGE as currently FireFox does not support the (Shift+Alt+D)</p><p>&emsp;- Run the following command:  dotnet run –configuration debug</p><p>&emsp;- Open up Google Chrome or Edge:  <http://localhost:5002></p><p>&emsp;- Press F12</p><p>&emsp;- Press Shift + Alt+D</p><p>&emsp;- A new Tab will open, copy the command provided and run it.</p><p>&emsp;- Another browser window will pop up </p><p>&emsp;- Press F12 </p><p>&emsp;- Press Shift+Alt+D again</p><p>&emsp;- In the Developer tools click on the “Sources” tab, you’ll see the wasm folder (expand and you’ll see the C# files as if you were in visual studio)</p>|
| :- |



|Here’s a visual description of the above debugging process from Google Chrome|
| :- |
||


|Here’s the Blazor Web Application with JQuery DataTables.  As you type in the search box it will look at ALL of the data and find anything that matches what you type.|
| :- |
||

Page  PAGE  \\* Arabic  \\* MERGEFORMAT 7 of  NUMPAGES  \\* Arabic  \\* MERGEFORMAT 7

