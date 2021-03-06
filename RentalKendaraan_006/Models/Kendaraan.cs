﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_006.Models
{
    public partial class Kendaraan
    {
        public Kendaraan()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }

        public int IdKendaraan { get; set; }

        [Required(ErrorMessage = "Nama Kendaraan Wajib Diisi!")]
        public string NamaKendaraan { get; set; }

        [Required(ErrorMessage = "Nomor Polisi Wajib Diisi!")]
        public string NoPolisi { get; set; }

        [RegularExpression ("^[0-9]*$", ErrorMessage ="Hanya diisi oleh angka!")]
        public string NoStnk { get; set; }
        public int? IdJenisKendaraan { get; set; }
        [Required(ErrorMessage ="Ketersediaan Wajib diisi!")]
        public string Ketersediaan { get; set; }

        public JenisKendaraan IdJenisKendaraanNavigation { get; set; }
        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
