using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_006.Models
{
    public partial class Pengembalian
    {
        public int IdPengembalian { get; set; }

        [Required(ErrorMessage = "Tanggal Pengembalian Wajib Diisi!")]
        public DateTime? TglPengembalian { get; set; }
        public int? IdPeminjaman { get; set; }
        public int? IdKondisi { get; set; }
        [Required(ErrorMessage = "Denda Wajib Diisi!")]
        public int? Denda { get; set; }

        public KondisiKendaraan IdKondisiNavigation { get; set; }
        public Peminjaman IdPeminjamanNavigation { get; set; }
    }
}
