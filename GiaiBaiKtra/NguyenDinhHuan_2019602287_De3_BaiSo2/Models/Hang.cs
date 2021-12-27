namespace NguyenDinhHuan_2019602287_De3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hang")]
    public partial class Hang
    {
        [Key]
        [StringLength(10)]
        public string Mahang { get; set; }

        [StringLength(50)]
        public string Tenhang { get; set; }

        [StringLength(50)]
        public string Loai { get; set; }

        public int? Gia { get; set; }
    }
}
