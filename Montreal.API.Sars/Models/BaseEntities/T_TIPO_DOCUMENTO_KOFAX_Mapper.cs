using System.Data.Entity.ModelConfiguration;

namespace Montreal.RSUNI.CustomPanel.Models.BaseEntities
{
    public class T_DOCUMENTO_ELETRONICO_Mapper : EntityTypeConfiguration<T_DOCUMENTO_ELETRONICO>
    {
        public T_DOCUMENTO_ELETRONICO_Mapper()
        {
            //ToTable Qual tabela pertecente ao relacionamento.
            //HasKey Chave primária
            //HasOptional relação 0.1 - *
            //HasRequired Relação 1 - *
            //WithMany Setando qual tabela irá receber o mapeamento.
            //HasForeignKey Setando qual é o campo do relacionamento.
            // Primary Key
            this.HasKey(t => t.COD_DOCUMENTO_ELETRONICO);

            // Properties
            this.Property(t => t.NOM_ARQUIVO)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.STR_GUID_KOFAX)
                .HasMaxLength(50);

            this.Property(t => t.STR_NOTA_REJEICAO)
                .HasMaxLength(1000);

            this.Property(t => t.STR_JUSTIFICATIVA)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("T_DOCUMENTO_ELETRONICO");
            this.Property(t => t.COD_DOCUMENTO_ELETRONICO).HasColumnName("COD_DOCUMENTO_ELETRONICO");
            this.Property(t => t.NOM_ARQUIVO).HasColumnName("NOM_ARQUIVO");
            this.Property(t => t.STR_GUID_KOFAX).HasColumnName("STR_GUID_KOFAX");
            this.Property(t => t.COD_LOTE).HasColumnName("COD_LOTE");
            this.Property(t => t.COD_TIPO_DOCUMENTO).HasColumnName("COD_TIPO_DOCUMENTO");
            this.Property(t => t.COD_STATUS).HasColumnName("COD_STATUS");
            this.Property(t => t.DAT_ENTRADA).HasColumnName("DAT_ENTRADA");
            this.Property(t => t.NUM_PROTOCOLO).HasColumnName("NUM_PROTOCOLO");
            this.Property(t => t.STR_NOTA_REJEICAO).HasColumnName("STR_NOTA_REJEICAO");

            this.Property(t => t.COD_LOTE_NOVO).HasColumnName("COD_LOTE_NOVO");
            this.Property(t => t.STR_JUSTIFICATIVA).HasColumnName("STR_JUSTIFICATIVA");

            // Relationships
            this.HasOptional(t => t.T_DOCUMENTO)
                .WithMany(t => t.T_DOCUMENTO_ELETRONICO)
                .HasForeignKey(d => d.NUM_PROTOCOLO);
            this.HasRequired(t => t.T_LOTE)
                .WithMany(t => t.T_DOCUMENTO_ELETRONICO)
                .HasForeignKey(d => d.COD_LOTE);
            this.HasRequired(t => t.T_STATUS_DOCUMENTO_ELETRONICO)
                .WithMany(t => t.T_DOCUMENTO_ELETRONICO)
                .HasForeignKey(d => d.COD_STATUS);
            this.HasRequired(t => t.T_TIPO_DOCUMENTO)
                .WithMany(t => t.T_DOCUMENTO_ELETRONICO)
                .HasForeignKey(d => d.COD_TIPO_DOCUMENTO);
            
        }
    }
}