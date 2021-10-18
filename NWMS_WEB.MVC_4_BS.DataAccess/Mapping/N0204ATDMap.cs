using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data.Entity.ModelConfiguration;
using NUTRIPLAN_WEB.MVC_4_BS.Model;

namespace NUTRIPLAN_WEB.MVC_4_BS.DataAccess.Mapping
{
    public class N0204ATDMap : EntityTypeConfiguration<N0204ATD>
    {
        /// <summary>
        /// Classe de mapeamento da classe N0204ATD, utilizada para difinir padrões de BD;
        /// </summary>
        public N0204ATDMap()
        {
            // Primary Key
            this.HasKey(t => t.CODATD);

            // Properties
            this.Property(t => t.CODATD)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DESCATD)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SITATD)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            
            

            // Table & Column Mappings
            this.ToTable("N0204ATD", Enums.OracleBDName);
            this.Property(t => t.CODATD).HasColumnName("CODATD");
            this.Property(t => t.DESCATD).HasColumnName("DESCATD");
            this.Property(t => t.SITATD).HasColumnName("SITATD");
        }
    }
}
