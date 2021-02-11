using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Models
{
    public class ToDoItem
    {
        public enum ItemType
        {
            Work,
            Exercise,
            Shopping,
            Leisure,
            Other
        }

        public int ID { get; set; }

        [Display(Name = "Title")]
        public string TaskName { get; set; }

        public string Description { get; set; }

        /// <summary>
        /// Egen typ, se enum ovan. I databasen lagras det som siffror
        /// som representerar de olika värdena. Om man vill kan man
        /// konfigurera detta annorlunda, men ej huvudfokus i denna demo.
        /// </summary>
        [Display(Name = "Type")]
        public ItemType TypeOfTask { get; set; }

        public bool Done { get; set; }
    }
}