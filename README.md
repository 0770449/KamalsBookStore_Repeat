# KamalsBookStore
Kamaljeet Kaur


    Start project with great Andrew Steele

    Initially Added Bootswatch theme

    Then Added dropdown in nav bar

    Added 3 project class KamalsBooks.DataAccess, KamalsBooks.Models, KamalsBooks.Utility

    Delete migration folder and move Data folder into DataAccess
   
    Added customers area

    Move Home view to customers area

    Edit layout path after moved _ViewStart into Area Customers Views

    run add-migration AddDefaultIdentityMigration. Succeeded. File name: 20221111194841_AddDefaultIdentityMigration.cs

    create file Category.cs in Model.

     Add Category into DBContext file. TODO: run command add-migration AddCategoryToDb 
     
     update-database

     part 2.2  Repository

     started the repository and category

     typing the code of CateoryRepository and Repository files
     Repository.cs copied from the given files
     Add and modify CategoryRepository.cs
     
      complited to the CoverType model 

 added th Id and Name in the CoverType.cs file

add the CoverTypeRepository Clas

 added the ICoverTypeRepositry Interface 

 made changes in the unitOfWork and IunitOfWork files

 added the migration AddCoverTypeToDb to the migration folder
 added the files for the covertype in view



     Create ISP_Call file and install Dapper package

     I made the Sp_Call.cs and ISP_Call.cs(interface) files in the given repository

     Following this I wrote the code for unitofwork file and Iunitofwork.cs file according to the given code
     Add UnitOfWork in startup.cs config

     Add Category Controller and Index view for Category

    In -Layout.cshtml file, move the 'Category' link to the Content management drop down.Now its showing in the drop list of it
    Modified the index.cshtml  inorder to add the icons

    Added category.js

    added the Upsert.cshtml file,copied given code in it,modified it
    In the Index.cshtml file added the asp-action where its required

    Remove the _db.SaveChanges from the CategoryRepository.cs file and move the _unitOfWork.Save() method with the return RedirectToaction method. 

    To perform delete operation Add the delete functionality in category.js 
    Add the Delete(url) functioncode 
    Finished with  part 2.3.......

 complited to the CoverType model 

 added th Id and Name in the CoverType.cs file

 add the CoverTypeRepository Clas

 added the ICoverTypeRepositry Interface 

 made changes in the unitOfWork and IunitOfWork files

 added the migration AddCoverTypeToDb to the migration folder

 added the files for the covertype in view
