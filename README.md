# Sectors

Contents
========

 * [What](#what)
 * [Installation](#installation)
 * [Usage](#usage)
 * [Git Integration](#git-integration)
 * [HTML and SQL](#html-and-sql)
 * [Categories](#categories)


### What?


+ API project (.NET 5) using EF Core.
+ UI project using BlazorWasm (.NET 6).
+ Add form to DB as user.
+ Guid property to mimic unique user in a session.




### Installation
---

Download as `root`.

Get packages.
This project uses the [MudBlazor](https://mudblazor.com/) library. In case package manager isn't able to get it automatically, it can be installed with the command: `dotnet add package MudBlazor`.


### Usage
---

Make sure startup projects are in the correct order.

There should be no setup needed, the database will be ensure created and populated with sectors on running the program.

If there are any issues, you may have to look at the ports of the two projects. The API project endpoint is stored as the first variable in the Blazor Index page as `_serviceEndpoint`.

The UI element above the form that says **Current User:** followed by a code is there to mimic user credentials and have a unique user with forms per "session".
I did this to have a specific customer to get when repopulating the form for editing. You can change the current user with the button under it.


### HTML and SQL
---

* The html file is saved in the Blazor project folder under `multiselect.html`.

* The SQL database generation script is saved, also, in the Blazor project folder under `multiselect_datadump.sql`.



### Categories
---
Implementing a category property for the Sector and grouping the multi-select by categories would be the plan, but I discovered much too late into the project that MudBlazor doesn't have that functionality (unlike other Blazor libraries) :D 




### Cheers


