using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Btap1WA.Models;

[Table("DSNYC")]
public partial class Dsnyc
{
    [Key]
    [Column("STT")]
    public int Stt { get; set; }

    [Column("TEN")]
    public string? Ten { get; set; }

    [Column("NAMSINH")]
    public string? Namsinh { get; set; }

    [Column("DIACHI")]
    public string? Diachi { get; set; }

    [Column("TEL")]
    public string? Tel { get; set; }
}
