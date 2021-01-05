namespace QuanLyTaiKhoanATM.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("History")]
    public partial class History
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdHistory { get; set; }

        [Required]
        [StringLength(50)]
        public string Date { get; set; }

        public int Money { get; set; }

        public int IdUser { get; set; }

        public virtual Account Account { get; set; }
    }
}
