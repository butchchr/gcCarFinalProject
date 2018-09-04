using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using gcCarFinalProject.Domain.Models;

namespace gcCarFinalProject.Data.Maps
{
    class CarMap : EntityTypeConfiguration<Car>
    {
        public CarMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Id)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}