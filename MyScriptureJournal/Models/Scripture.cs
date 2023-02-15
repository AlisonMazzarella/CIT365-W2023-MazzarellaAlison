using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyScriptureJournal.Models
{
    public class Scripture
    {
        public int Id { get; set; }
        public string? Book { get; set; }

        [Display(Name = "Date Added")]
        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }
        public string? Note { get; set; }
        public decimal Chapter { get; set; }
        public decimal Verse { get; set; }
    }
}
