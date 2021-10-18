using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data.Entity.ModelConfiguration; using NUTRIPLAN_WEB.MVC_4_BS.Model;

namespace NUTRIPLAN_WEB.MVC_4_BS.DataAccess.Mapping
{
    public class N0000RELMap : EntityTypeConfiguration<Model.N0000REL>
    {
        /// <summary>
        /// Classe de mapeamento da Classe N0000REL, utilizado para definir padr�es de tabelas em BD;
        /// </summary>
        public N0000RELMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MENU, t.ABRREL });

            // Properties
            this.Property(t => t.MENU)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ABRREL)
                .IsRequired()
                .HasMaxLength(500);

                        
            
// Table & Column Mappings
            this.ToTable("N0000REL", Enums.OracleBDName);
            this.Property(t => t.MENU).HasColumnName("MENU");
            this.Property(t => t.ABRREL).HasColumnName("ABRREL");
        }
    }
}
