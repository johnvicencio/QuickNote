using System;
using QuickNote.MVC.Controller;
using QuickNote.MVC.Model;

namespace QuickNote.MVC.View;

public class NoteView
{

    public void Menu(string file)
    {
        
        NoteManager noteManager = new NoteManager(file);

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("QuickNote");
            Console.WriteLine("1. Create a note");
            Console.WriteLine("2. Display all notes");
            Console.WriteLine("3. Display a note based on an ID");
            Console.WriteLine("4. Update a note");
            Console.WriteLine("5. Delete a note");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter note title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter note content: ");
                    string content = Console.ReadLine();
                    Note newNote = new Note { Title = title, Content = content };
                    noteManager.Add(newNote);
                    Console.WriteLine("Note created successfully.");
                    break;
                case 2:
                    List<Note> allNotes = noteManager.GetAll();
                    if (allNotes.Count == 0)
                    {
                        Console.WriteLine("No notes found.");
                    }
                    else
                    {
                        foreach (Note note in allNotes)
                        {
                            if (note.DateModified != DateTime.MinValue)
                            {
                                Console.WriteLine($"ID: {note.Id}, Title: {note.Title}, Content: {note.Content}, Created on {note.DateCreated} and Modified on {note.DateModified}.");
                            }
                            else
                            {
                                Console.WriteLine($"ID: {note.Id}, Title: {note.Title}, Content: {note.Content}, Created on {note.DateCreated}.");
                            }
                        }
                    }
                    break;
                case 3:
                    Console.Write("Enter note ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Note foundNote = noteManager.GetById(id);
                    if (foundNote == null)
                    {
                        Console.WriteLine("Note not found.");
                    }
                    else
                    {
                        Console.WriteLine($"ID: {foundNote.Id}, Title: {foundNote.Title}, Content: {foundNote.Content}");
                    }
                    break;
                case 4:
                    Console.Write("Enter note ID: ");
                    int updateId = int.Parse(Console.ReadLine());
                    Note existingNote = noteManager.GetById(updateId);
                    if (existingNote == null)
                    {
                        Console.WriteLine("Note not found.");
                    }
                    else
                    {
                        Console.Write("Enter new note title (press enter to keep existing value): ");
                        string newTitle = Console.ReadLine();
                        if (!string.IsNullOrEmpty(newTitle))
                        {
                            existingNote.Title = newTitle;
                        }
                        Console.Write("Enter new note content (press enter to keep existing value): ");
                        string newContent = Console.ReadLine();
                        if (!string.IsNullOrEmpty(newContent))
                        {
                            existingNote.Content = newContent;
                        }
                        noteManager.Update(existingNote);
                        Console.WriteLine("Note updated successfully.");
                    }
                    break;
                case 5:
                    Console.Write("Enter note ID: ");
                    int deleteId = int.Parse(Console.ReadLine());
                    noteManager.Delete(deleteId);
                    Console.WriteLine("Note deleted successfully.");
                    break;
                case 6:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.WriteLine();
        }
    }
}

