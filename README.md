# Code Review 11 (Sweet Market)

## by _**Jonathan Delcid**_

### _April 9, 2022_

#### _In this website, a user is able to log in, log out and add thier favorite sweets and flavors!_

## Technologies Used
- _C#_
- _.Net 5_
- _REPL_
- _MySQL_
- _Razor_
- _ASP.NET Core_

## Project Title: Factory

## Project Setup/Installation Instructions:
- _Open the terminal on your local computer._

- _Navigate to the parent directory of your preference._

- _Clone this project using ```$ git clone https://github.com/delcidj22/code-review-11```_

- _Navigate to the top level of the directory with the command ```$ cd code-review-11```_

- _Determine if the MySql server is running locally by typing the following into the command line mysql -uroot -p[The password you set up]_

- _Open MySql Workbench. Once open select the Administration tab. Next select Data Import/Restore. This opens up the Data Import window with the Import from Disk tab open. Select the radio button for Import from Self-Contained File. Click the button with the three dots (if on windows) or two dots (if on mac) at the end of the path field. This will open a window to search for the sql dump file on your local disk. Navigate to the root directory of the cloned project and select jonathan.delcid.sql and click the open button. Next, press the New... button. This will open a window where you can choose the name of the imported schema.Choose a name appropriate to the project, e.g. Hair Salon and click Okay. We'll need this name later when setting up the project to work with this schema. If on a mac, click the Start Import button. If on a windows machine, switch to the Import Progress tab on the Data Import page. Click the Import button. Finally, re-click on the Schemas tab. Right-click in the Schemas window, and select Refresh All. The imported schema should now be listed. *Navigate back to the HairSalon/ directory and create a file named: appsettings.json. In this file, add the fowling configuration to set up the project to work with the schema you imported: { "ConnectionStrings": { "DefaultConnection": "Server=localhost;Port=3306;database=[THE-NAME-YOU-CHOSE-WHEN-IMPORTING-THE-SCHEMA];uid=root;pwd=[YOUR-PASSWORD-HERE];" }}_

- _In the Factory main directory run dotnet build on the command line._

- _Run dotnet run on the command line to start the web server._


## Known Bugs
- _Nothing happens when logging in._



## License
[MIT License](https://opensource.org/licenses/MIT) Published _**2022**_ _**Jonathan Declid**_

## Contact Information
_If you encounter any issues with this site, please contact Jonathan Delcid at [jdelcid23@gmail.com]_
Copyright (c) _04/09/2022_ _Jonathan Delcid_