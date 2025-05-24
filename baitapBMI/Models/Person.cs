using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace tinhchisoMBI.Models
{
    [Table("chisoBMI")]
    public class chisoBMI
    {
        [Key]
        // Thông tin cá nhân
        public string? Ten { get; set; }
        public int Tuoi { get; set; }
        public double ChieuCao { get; set; }
        public double CanNang { get; set; }

        // Điểm
        public int DiemA { get; set; }
        public int DiemB { get; set; }
        public int DiemC { get; set; }

        // Đơn hàng
        public string? DonHang1 { get; set; }
        public string? DonHang2 { get; set; }
        public string? DonHang3 { get; set; }

        // Kết quả
        public double? BMI { get; set; }
        public double? DiemTong { get; set; }
        public double? TongTien { get; set; }

        public string? Action { get; set; } // để biết nút nào được bấm
    }

}

