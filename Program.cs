using QuickNote.MVC.View;
using System;
using System.Diagnostics;
using System.IO;

string file = "notes.json";

var view = new NoteView();
view.Menu(file);