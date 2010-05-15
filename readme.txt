This is the sample application used during my Leveraging Conventions in .NET 
talk at Austin Code Camp 2010.

Requirements:
.NET Framework 4
SQL Server, code assumes (but can be changed in src/MyApp/Database.cs:
  - Sql Server 2008
  - integrated security
  - an empty database named codecamp2010 exists
IronRuby 1.0, if you want to run the rake script to generate the database schema


Files:
src/ - the source code of a simple FubuMVC website used to demo the concepts
lib/ - the 3rd party libraries needed by the site
notes.txt - my speaking notes, walks through the demo, step by step


Branches:
The repository contains a number of branches, to represent different states
of the code.

master - contains the starting point for the sample application, before any of
  the conventions being demonstrated have been applied. Also contains the latest
  notes.txt and intro slide.

* The mini-demos branches off of master, and do not rely on each other. Any changes
for the website that should apply to all demos are made in master, and then the
branches are rebased on master.

dates - contains the code used to demonstrate conventionally applying jquery
  date pickers and time pickers to appropriates fields

help - contains the code used to demonstrate conventionally applying context-
  sensitive help throughout the application
  
helpstart - a pointer to the one commit that I cherry-pick when starting the
  help demo, since it contains a bunch of styles I don't want to manually type.

attr - contains the code used to demonstrate conventionally adding client side
  validation and database schema generation based on custom attributes applied
  to the model
  
live - the other branches were just used during preparation. The live branch is
  the actual code I wrote during the Austin Code Camp presentation. It
  implements all of the demos outlined in the other branches. The separate
  branches are probably easier to follow, since I did more granular commits.