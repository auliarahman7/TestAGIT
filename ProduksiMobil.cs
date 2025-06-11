using System;
using System.ComponentModel.DataAnnotations;

public class ProduksiMobil
{
    [Key]
    public int Id { get; set; }

    public int Senin { get; set; }
    public int Selasa { get; set; }
    public int Rabu { get; set; }
    public int Kamis { get; set; }
    public int Jumat { get; set; }
    public int Sabtu { get; set; }
    public int Minggu { get; set; }

    public DateTime TanggalInput { get; set; } = DateTime.Now;
}
 