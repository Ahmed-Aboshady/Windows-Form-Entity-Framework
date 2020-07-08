namespace CoursesCenter
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("course")]
    public partial class course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int crsid { get; set; }

        [Required]
        [StringLength(50)]
        public string crsname { get; set; }

        public int? duration { get; set; }
    }
}
