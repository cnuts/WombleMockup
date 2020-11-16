Three controllers are in this project to present the overall ideas.

1)CollectionController - this controller demonstrates how you can return collection of plain C# objects and return JSON
2)SampleController - 
3)SqlController - This demonstates at a low level how .net core allows data access.

The typical method you see in manuals is with Entity Framework.  Entity framework wraps you SQL database and abstracts away the typically data access we are used to in ADO
.Net core uses dependency injection.  If you are not familiar with this pattern, I suggest you get familiar with how dependency injection is done in in .NetCore.  It is a big shift away from .Net framework howevever you could do this previously.
In the SQL Controller I'm demonstrating how you inject the configuration interface which points to the TEDS SQL connection string in appsettings.json.
This is used to perform boiler plate ADO call to execute a bogus stored procedure without parameters.


Keep in mind I don't believe Azure allows you to access configuration in this manner demonstrated in SqlController.
If the database is accessible, there will be a token or configuration store you use that will contain this value.  It has been a few years so I don't clearly recall how this is done but it is common practice.


When designing your API I suggest you write out everything on paper first to confirm what data is needed by the calling client along with the various parameters you'll need from the client to get specific datasets.


If you have additional questions you may email me ssr75@protonmail.com  - Courtney