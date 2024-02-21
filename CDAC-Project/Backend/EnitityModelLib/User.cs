using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnitityModelLib
{
    [Table("T_User")]
    public class User
    {
        public User()
        {

        }

        public User(string EmailId, string MobileNo, string Name, int UserId)
        {
            this.EmailId = EmailId;
            this.MobileNo = MobileNo;
            this.Name = Name;
            this.UserId = UserId;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int UserId { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }

        public string MobileNo { get; set; }
        public bool IsOnline { get; set; }

        public bool IsLocked { get; set; }
     
        public int RoleId { get; set; }
        public string Name { get; set; }

        public string AdharNumber { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"UserId: {UserId}, EmailId: {EmailId}, Password: {Password}, MobileNo: {MobileNo}, IsOnline: {IsOnline}, IsLocked: {IsLocked}, RoleId: {RoleId}, Name: {Name}, AdharNumber: {AdharNumber}, Address: {Address}";
        }



    }
}
