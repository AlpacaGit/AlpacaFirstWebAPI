using System.ComponentModel.DataAnnotations;

namespace Alpaca.Tool.WebAPI.First.Models
{
    /// <summary>
    /// メンバーマスタ
    /// </summary>
    public class M_Member
    {
        [Key]
        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public string MemberNameKana { get; set; }
        public string MemberNameEng { get; set; }
        public int? ImageColorID { get; set; }
        public string? Grade { get; set; }
        public short? Age { get; set; }
        public string? BirthDay { get; set; }
        public int? Height { get; set; }
        public string? BloodType { get; set; }
        public int? Bust { get; set; }
        public int? Waist { get; set; }
        public int? Hip { get; set; }
        public string? Detail { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public bool Invalid_FLG { get; set; }

    }
}
