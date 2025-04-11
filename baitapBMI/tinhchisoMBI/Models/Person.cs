using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace tinhchisoMBI.Models
{
    [Table("Persons")]
    public class Person
     {
     // Thông tin cá nhân
     [Key]
     public string Ten { get; set; }
     public int Tuoi { get; set; }
     public double ChieuCao { get; set; }
     public double CanNang { get; set; }

     // Điểm
     public int DiemA { get; set; }
     public int DiemB { get; set; }
     public int DiemC { get; set; }

     // Đơn hàng
     public string DonHang1 { get; set; }
     public string DonHang2 { get; set; }
     public string DonHang3 { get; set; }

     // TổngTổng
     public double? BMI { get; set; }
     public double? DiemTong { get; set; }
     public double? TongTien { get; set; }

     public string Action { get; set; } 
 }
    public class Employee : Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}

