using SECSENAC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace SECSENAC.EntityTypeConfigurations
{
    public class OcorrenciaConfiguration : EntityTypeConfiguration<Ocorrencia>
    {
        public OcorrenciaConfiguration()
        {
            ToTable("Ocorrencia");
            HasKey(o => o.Id);

            Property(o => o.Descricao)
                .IsRequired()
                .HasMaxLength(2000);

            Property(o => o.Local)
                .IsRequired()
                .HasMaxLength(200);

            Property(o => o.NumVitimas)
                .IsRequired();

            HasMany(o => o.Delitos)
                .WithMany(d => d.Ocorrencias)
                .Map(m => {
                    m.ToTable("OcorrenciaDelitos");
                    m.MapLeftKey("OcorrenciaId");
                    m.MapRightKey("DelitoId");
                });
        }
    }
}