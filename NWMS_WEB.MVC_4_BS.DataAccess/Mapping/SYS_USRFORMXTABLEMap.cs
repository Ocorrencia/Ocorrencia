using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data.Entity.ModelConfiguration; using NUTRIPLAN_WEB.MVC_4_BS.Model;

namespace NUTRIPLAN_WEB.MVC_4_BS.DataAccess.Mapping
{
    public class SYS_USRFORMXTABLEMap : EntityTypeConfiguration<Model.SYS_USRFORMXTABLE>
    {
        /// <summary>
        /// Classe de mapeamento da classe SYS_USRFORMXTABLE, utilizada para difinir padrões de BD;
        /// </summary>
        public SYS_USRFORMXTABLEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODFORM, t.CODTABLE });

            // Properties
            this.Property(t => t.CODFORM)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODTABLE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TIPOFORM)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

                        
            
// Table & Column Mappings
            this.ToTable("SYS_USRFORMXTABLE", Enums.OracleBDName);
            this.Property(t => t.CODFORM).HasColumnName("CODFORM");
            this.Property(t => t.CODTABLE).HasColumnName("CODTABLE");
            this.Property(t => t.TIPOFORM).HasColumnName("TIPOFORM");

            // Relationships
            this.HasRequired(t => t.SYS_USRFORM)
                .WithMany(t => t.SYS_USRFORMXTABLE)
                .HasForeignKey(d => d.CODFORM);
            this.HasRequired(t => t.SYS_USRTABLE)
                .WithMany(t => t.SYS_USRFORMXTABLE)
                .HasForeignKey(d => d.CODTABLE);

        }
    }
}
