using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.Models
{
    public class Student
    {
        [Required(ErrorMessage ="İsminizi giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email giriniz")]
        [EmailAddress(ErrorMessage = " lütfen mail adresinizi düzgün giriniz")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefon giriniz")]
        public int Phone { get; set; }

        [Required(ErrorMessage = "Kursa katılıp katılmayacğınızı giriniz")]
        public bool? WillAttend { get; set; }
    }
}
