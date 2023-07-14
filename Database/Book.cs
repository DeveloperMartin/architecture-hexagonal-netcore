using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdBook { get; set; }
        public string Title { get; set; }
        public string Sinopsis { get; set; }
        public int Score { get; set; }
        public int State { get; set; }
    }
}