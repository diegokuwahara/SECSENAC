using SECSENAC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace SECSENAC.EntityTypeConfigurations
{
    public class DelitoConfiguration : EntityTypeConfiguration<Delito>
    {
        public DelitoConfiguration()
        {
            ToTable("Delito");

            HasKey(d => d.Id);

            Property(o => o.Nome)
                .IsRequired()
                .HasMaxLength(100);

            Property(o => o.Artigo)
                .IsRequired();
        }
    }
}