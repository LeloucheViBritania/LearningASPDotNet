using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DynamikTemplateGrp.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        [Required, StringLength(50)]
        public string LastName { get; set; }
        [Required, StringLength(15)]
        public string Mdp { get; set; }
        public string Comment { get; set; }

        public Cours Cours { get; set; }

    }

    public enum Categorie { 

        Informatique, 
        Histoire,
        Anglais,
        Other
    }


    public class Cours
    {
        [Key]
        public int CoursID { get; set; }
        [MaxLength(100)]
        public string NameCours { get; set; }
        [StringLength(1000)]
        public string Comment { get; set; }

        public Categorie? Category { get; set; }
    }


    public class Follow
    {
        [Key]
        public int FollowId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MimeMapping/yyyy}")]
        public DateTime Debut { get; set; }

        public bool IsFinished { get; set; }

    }
}