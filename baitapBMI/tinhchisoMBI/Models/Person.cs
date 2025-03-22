using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace tinhchisoMBI.Models
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public required string? ten { get; set; }
        public required string? tuoi { get; set; }
        public double chieucao { get; set; }
        public double cannang { get; set; }
        public int diemA{ get; set; }
        public int diemB { get; set; }
        public int diemC { get; set; }
        public required string donhang1 { get; set; }
        public required string donhang2 { get; set; }
        public required string? donhang3 { get; set; }
  
    }
}

