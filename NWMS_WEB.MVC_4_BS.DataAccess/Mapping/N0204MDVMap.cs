using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data.Entity.ModelConfiguration;
using NUTRIPLAN_WEB.MVC_4_BS.Model;

namespace NUTRIPLAN_WEB.MVC_4_BS.DataAccess.Mapping
{
    public class N0204MDVMap : EntityTypeConfiguration<N0204MDV>
    {
        /// <summary>
        /// Classe de mapeamento da classe N0204MDV, utilizada para difinir padrões de BD;
        /// </summary>
        public N0204MDVMap()
        {
            // Primary Key
            this.HasKey(t => t.CODMDV);

            // Properties
            this.Property(t => t.CODMDV)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DESCMDV)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SITMDV)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

                        
            
// Table & Column Mappings
            this.ToTable("N0204MDV", Enums.OracleBDName);
            this.Property(t => t.CODMDV).HasColumnName("CODMDV");
            this.Property(t => t.DESCMDV).HasColumnName("DESCMDV");
            this.Property(t => t.SITMDV).HasColumnName("SITMDV");
        }
    }
}
