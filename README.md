# README

The ACME Inc Web App Prototype was designed in an effort to meet ACME's need to become an online store. With many things going online, ACME Inc had to make sure that they have an online presence so that they can reach a wider audience, grow their customer base and increase their profits. For these reasons, it is crucial that ACME Inc has an online store.

___

# Tools/Software Required:

* Microsoft Server Management Studio [FREE]
* Visual Studio [FREE]

___
# How To Setup The Application:
## Restore the database using Microsoft Server Management Studio: 
* Locate and open the folder titled 'Database'. This folder will contain a Microsoft Server Management Studio Database Backup File with a `.bacpac` extension. This file will be needed for restoring the database.
* Open Microsoft Server Management Studio.
* Right click on `Databases` on the left sidebar
* Select `Import Data-Tier Application...`.
* Click next 
* Select `Import from local disk` and navigate to the `.bacpac` file in the Database folder.
* Click next and restore the database. The DB should now be fully restored.
___
# Adding The ConnectionString
* Run the .sln file to open the project then click on 'Tools' and select 'Connect To Database'.
* Select your instance and select the database that you restored in Server Management Studio and thereafter test the connection and click 'OK'.
* Copy your connection string which should be displayed in the properties of your DB Context file.
* You may now paste your copied string in the AppSettings.json file.
* At this point you should be able to run the project succesfully.
___
# Demo Account Logins
**Administrator Login Details:**
**Email Address:**
admin@acme.com
**Password:**
123456

### Customer Login Details:
**Email Address:**
test@t.com
**Password:**
123456
___
# Advanced Features/Considerations: 
Security Features - SHA512 Encryption used.
Session Management used to define user roles privileges.
JS used to render graphs to show sales.
Custom layouts based on roles.
CSS styling used for visual features.
Session timeouts implemented.
___
