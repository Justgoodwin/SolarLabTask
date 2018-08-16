using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Notepad
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; } //Id of each tasks

        public string Task { get; set; } //task containments

        public string MachineName { get; set; } // who made a task

        public DateTime TimeWhenTaskCreated { get; set; }
    }
}