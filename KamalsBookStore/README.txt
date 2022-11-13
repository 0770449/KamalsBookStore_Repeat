2022-10-23
Build the initial default Application- ASp.NET Core MVC(C#)
-prepend my name KamalsBookStore
-individual Account Authentication 
-Added razor runtime -just for fun

Application project is called "KamalsBookStore"
1325 Create github repo
1328 ...nowconfirming the ability to push to the repo
-Hit create and then reviwed the default App
12:46

Today the previous part mentioned above finished at 1325
1328 created github repo and now confirming the ability to push the repo
Adding info to the readmeon the friday and tweaked the HomeController  and try to get  return the Error page

Added error public I Action On HomeController
Comment the res below code from response to except last 2 brackets
added info to the readme omn friday ...home controller..added errors does not work
tweaked the Homecontroller and try to get return the error page...bootstarp
then layoutfile...line7..change min to css..relative address...use files
1318
completed the debugging exercise...ohh jezz i have homework...jhoe do i cell the error.cshtmlfile?

the class helped me apply a bootstrap theme first download the bootstrap.css and rename the existing bootstrap.css
then modify the link rel in _layout.cshtml

08:15-
update the startup.cs by removing some content from there.
Checked the whole file that it need smore chnages or no.

Build the project and  it was successful.

checkeed the Homecontroller by tweaked it ...
checked the error I action .....to set up errorless code.
As followed the slides review the models folder as well.

Feeling tired but trying to do whereever I can do .
I saw the after footer credentials in _layout.cshtml file
Now come to the _loginPartial.cshtml file to check the project cerdentials.

Same thing done with the _validationScriptsPartial.cshtml
To check the layout I visit the _viewStart.cshtml file.

Starting the Bootstrap.....
Go the google and search the bootswatch theme...
I tried by opening every theme which looks nice.
So finally I decided to use the 'vapor' theme in my project.
Then I downloaded the bootstrap.css for that project to insert.
Then I go to the wwwroot folder then lib>bootstap>dist>css...
But the bootswatch.css file was already there. so I rename that file...
and insert the new bootstrap.css in that folder.

Then added the script and some css in the layout file.
Then go the _Layout.cshtml to the css file  name from bootstrap.min.css to bootstrap.css.
changed that...
Then do changes in the layout according to the css like bg-white to bg-primary and so on....
Removes the refrence from the layout...

10:00PM-
created three new project from tthe original one 
KamalsBooks.DataAccess
KamalsBooks.Models
KamalsBooks.Utility

Then delete the data folder from the original one and put in the KamalsBooks.DataAccess project
Install the required packages
Then deletd the migration from the data folder.
Modify the namespace in ApplicationDbContext.Cs file
Delete Class1.cs files from every project

10:15PM-
Then delete models folder and copied it to the KamalsBooks.Models project



.......Date:11/4/2022 
       Time: 04:40PM..........
Start project again.......
Finished everything before creating three new projects.


.......Date:11/11/2022 
       Time: 03:15PM..........
-Try to complete Setting up the project(Part1)
-For this I reviewed everything after creating three new projects like delete data folder,model etc.....
-After this Modify Views > Shared >Error.cshtml
-Added reference to the .DataAccess and .Models projects and rename Models to ViewModels
- Change the ErrorViewModels.cs namespace .Models.ViewModels 
-Modify Startup.cs
-Run the application and review errors.
- Remove the using statement
- Correct any default reference to ErrorViewModel to the new .Models.ViewModels.ErrorViewModels 
-Try to run the project but contains some errors

11:09PM
-In the Utility project,create a static details class called SD.cs and modifies its properties
-Add reference to the main project
-In the DataAccess project add project references to Models and Utility 

11:18PM
-Add a ‘Customers’ area to Areas 
-Change the routes in Startup.cs
-Move the HomeController.cs to the Area > Customer > Controller folder and delete Data and Models.
-Edit the HomeController.cs
-Move Views > Home and modify the HomeController namespace
- Copy _ViewImport and _ViewStart to Customer Area 
-Add a new Admin area in Areas
- Add the proper view files and delete the Data and Models folder
- Delete the Controllers 

11:35PM
Run thr project and is error free now

 


