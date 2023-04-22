using System;
using Newtonsoft.Json;
using QuickNote.MVC.Model;

namespace QuickNote.MVC.Controller;

public class NoteManager
{
    private List<Note> notes;
    private string filePath;

    public NoteManager(string filePath)
    {
        this.filePath = filePath;

        if (!File.Exists(filePath))
        {
            File.Create(filePath).Close();
        }

        string json = File.ReadAllText(filePath);
        notes = JsonConvert.DeserializeObject<List<Note>>(json) ?? new List<Note>();
    }

    public void Add(Note note)
    {
        int id = notes.Count > 0 ? notes.Max(n => n.Id) + 1 : 1;
        note.Id = id;
        note.DateModified = DateTime.MinValue;
        notes.Add(note);
        Save();
    }

    public List<Note> GetAll()
    {
        return notes;
    }

    public Note GetById(int id)
    {
        return notes.Find(n => n.Id == id);
    }

    public void Update(Note note)
    {
        Note existingNote = notes.Find(n => n.Id == note.Id);
        if (existingNote != null)
        {
            existingNote.Title = note.Title;
            existingNote.Content = note.Content;
            existingNote.DateModified = DateTime.Now;
            Save();
        }
    }

    public void Delete(int id)
    {
        notes.RemoveAll(n => n.Id == id);
        Save();
    }

    private void Save()
    {
        string json = JsonConvert.SerializeObject(notes, Formatting.Indented);
        File.WriteAllText(filePath, json);
    }
}

