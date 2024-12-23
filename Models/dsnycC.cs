using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Btap1WA.Models;

public partial class dsnycC : DbContext
{
    public dsnycC()
    {
    }

    public dsnycC(DbContextOptions<dsnycC> options)
        : base(options)
    {
    }

    public virtual DbSet<Dsnyc> Dsnycs { get; set; } = null!;
}
   
