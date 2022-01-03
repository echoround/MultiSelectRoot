# Sectors

Contents
========

 * [What](#what)
 * [Installation](#installation)
 * [Usage](#usage)
 * [HTML and SQL](#html-and-sql)



### What?


+ API project (.NET 5) using EF Core.
+ UI project using BlazorWasm (.NET 6).
+ Class library.
+ Add form to DB as user.
+ Guid property to mimic unique user in a session.




### Installation
---

Download as `root`.

**Due to the Blazor UI project being .NET 6, this solution has to be run with _Visual Studio 2022_!**

Get NuGet packages.
This project uses the [MudBlazor](https://mudblazor.com/) library. In case package manager isn't able to get it automatically, it can be installed with the command: `dotnet add package MudBlazor`.


### Usage
---

Set the solution to launch with multiple startup projects, in correct order.

There should be no additional setup needed- the database will be ensure created and populated with sectors on running the program.

However, if there are any issues, it could be a mismatch of the ports of the two projects. The API endpoint is stored as the first variable in the Blazor `Form` component codebehind, as `_serviceEndpoint`.

The UI element above the form that says **Current User:** followed by a code is there to mimic user credentials and have a unique user with forms per "session".
I did this to have a specific customer to get when repopulating the form for editing. You can change the current user with the button under it.


### HTML and SQL
---

* The html file is saved in the BlazorUI project folder under `multiselect.html`.

* The SQL database generation script is saved, also, in the BlazorUI project folder under `multiselect_datadump.sql`.




