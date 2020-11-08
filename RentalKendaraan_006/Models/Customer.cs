using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_006.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }

        
        public int IdCustomer { get; set; }

        [Required(ErrorMessage = "Nama Customer Wajib Diisi!")]
        public string NamaCustomer { get; set; }

        [RegularExpression("^[0-9*$]", ErrorMessage = "Hanya boleh diisi oleh Angka!")]
        public string Nik { get; set; }

        [Required(ErrorMessage = "Alamat Wajib Diisi!")]
        public string Alamat { get; set; }

        [MinLength(10, ErrorMessage = "No. Hp Minimal 10 angka")]
        [MaxLength(13, ErrorMessage = "No. Hp Maksimal 13 angka")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "No Hp Hanya boleh diisi dengan Angka")]
        [Required(ErrorMessage = "No Hp Wajib Diisi")]
        public string NoHp { get; set; }


        public int? IdGender { get; set; }

        public Gender IdGenderNavigation { get; set; }
        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
