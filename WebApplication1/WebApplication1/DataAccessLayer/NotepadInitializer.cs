using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplication1.Models;

namespace WebApplication1.DataAccessLayer
{
    public class NotepadInitializer : DropCreateDatabaseIfModelChanges<NotePadContext>
    {
        protected override void Seed(NotePadContext context)
        {
            var notepadTasks = new List<Notepad> { };

            notepadTasks.ForEach(tasks => context.NotePad.Add(tasks));
            context.SaveChanges();
        }
    }
}