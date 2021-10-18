using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data.Entity.ModelConfiguration; using NUTRIPLAN_WEB.MVC_4_BS.Model;

namespace NUTRIPLAN_WEB.MVC_4_BS.DataAccess.Mapping
{
    public class N0020ABRMap : EntityTypeConfiguration<Model.N0020ABR>
    {
        /// <summary>
        /// Classe de mapeamento da classe N0020ABR, utilizada para difinir padrões de BD;
        /// </summary>
        public N0020ABRMap()
        {
            // Primary Key
            this.HasKey(t => t.CODUSU);

            // Properties
            this.Property(t => t.CODUSU)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

                        
            
// Table & Column Mappings
            this.ToTable("N0020ABR", Enums.OracleBDName);
            this.Property(t => t.CODUSU).HasColumnName("CODUSU");
            this.Property(t => t.ABREMP).HasColumnName("ABREMP");
            this.Property(t => t.ABRFIL).HasColumnName("ABRFIL");
            this.Property(t => t.ABRARM).HasColumnName("ABRARM");
            this.Property(t => t.USUCAD).HasColumnName("USUCAD");
            this.Property(t => t.DATCAD).HasColumnName("DATCAD");
            this.Property(t => t.USUALT).HasColumnName("USUALT");
            this.Property(t => t.DATALT).HasColumnName("DATALT");

            // Relationships
            this.HasRequired(t => t.SYS_USUARIO)
                .WithOptional(t => t.N0020ABR);

        }
    }
}
