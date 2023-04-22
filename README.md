# QuickNote
QuickNote is a C# console app that follows the MVC architecture. It uses a JSON file to store notes, with CRUD operations and SaveNotes method. Newtonsoft.Json is used for serialization/deserialization.

## Problem
If you want to create a simple note taking app that saves notes locally, you can structure it using the MVC design pattern. This involves separating the application into three classes: the model class that deals with data, the controller class that handles the logic and data coordination, and the view class that presents the data to the user. By doing this, you can organize your code and make it easier to maintain and modify.

## Solution
QuickNote is a C# console app that follows the MVC design pattern, separating data (model), logic (controller), and presentation (view) concerns. It uses a JSON file as a database to store notes and offers CRUD operations, allowing users to create, read, update, and delete notes. The application utilizes a Note class to represent a single note, with fields for ID, title, and content, and a NoteManager class to manage the collection of notes. The notes.json file serves as a persistent data store, and the Newtonsoft.Json library is used for serialization and deserialization of the notes collection to and from JSON format. The app provides a user menu with various options, including displaying all notes, displaying a specific note by ID, and updating or deleting a note by ID. The SaveNotes method is used to save changes made to the notes collection back to the JSON file.

## Pseudo Code
1. Create a C# console (.NET Core) application using Visual Studio.
2. Name the application QuickNote.
3. Create a folder: MVC, each with subfolders representing Model, View, and Controller.
4. Save classes Note into Model folder, NoteManager into Controller folder and Noteview into the View folder.
5. Make sure that the NoteManager controller handles the CRUD operations
6. The Note represents a data, where the controller communicates to this model to save it to JSON file, the view uses the controller as well to get various CRUD operations
7. Create a menu system by instantiating the view with a Menu() method

## What is JSON?
JSON, or JavaScript Object Notation, is a lightweight and text-based data format used for exchanging data between web servers and applications. It uses key-value pairs and arrays and is similar in structure to JavaScript objects. XML, on the other hand, is a markup language that uses tags and attributes to define elements and describe them. JSON is generally considered more lightweight, easier to read and write, and faster to parse than XML, making it more suitable for web-based applications. Compared to traditional relational databases, JSON databases offer more flexibility and faster query performance, but may not be as well-suited for complex queries or data analysis tasks.

## Using the application
1. Run the application.
2. A terminal window will show a menu for selection.
3. Follow the instructions on the screen to perform various CRUD operations.
4. Press 6 to exit the application.
