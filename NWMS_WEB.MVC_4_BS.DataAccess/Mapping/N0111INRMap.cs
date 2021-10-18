using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data.Entity.ModelConfiguration; using NUTRIPLAN_WEB.MVC_4_BS.Model;

namespace NUTRIPLAN_WEB.MVC_4_BS.DataAccess.Mapping
{
    public class N0111INRMap : EntityTypeConfiguration<Model.N0111INRModel>
    {
        /// <summary>
        /// Classe de mapeamento da classe N0111INRModel, utilizada para difinir padrões de BD;
        /// </summary>
        public N0111INRMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODEMP });

            // Properties
            this.Property(t => t.CODEMP)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

                        
            
// Table & Column Mappings
            this.ToTable("N0111INR", Enums.OracleBDName);
            this.Property(t => t.CODEMP).HasColumnName("CODEMP");
            this.Property(t => t.DATBAS).HasColumnName("DATBAS");
        }
    }
}
