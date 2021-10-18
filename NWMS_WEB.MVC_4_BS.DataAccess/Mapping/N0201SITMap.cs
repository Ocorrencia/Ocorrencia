using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data.Entity.ModelConfiguration; using NUTRIPLAN_WEB.MVC_4_BS.Model;

namespace NUTRIPLAN_WEB.MVC_4_BS.DataAccess.Mapping
{
    public class N0201SITMap : EntityTypeConfiguration<Model.N0201SIT>
    {
        /// <summary>
        /// Classe de mapeamento da classe N0201SIT, utilizada para difinir padr�es de BD;
        /// </summary>
        public N0201SITMap()
        {
            // Primary Key
            this.HasKey(t => t.CODSIT);

            // Properties
            this.Property(t => t.CODSIT)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DESSIT)
                .IsRequired()
                .HasMaxLength(50);

                        
            
// Table & Column Mappings
            this.ToTable("N0201SIT", Enums.OracleBDName);
            this.Property(t => t.CODSIT).HasColumnName("CODSIT");
            this.Property(t => t.DESSIT).HasColumnName("DESSIT");
        }
    }
}
