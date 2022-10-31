using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Note.Persistence.EntityTypeConfigurations
{
    public class NoteConfiguration : IEntityTypeConfiguration<Notes.Domain.Note>
    {
        public void Configure(EntityTypeBuilder<Notes.Domain.Note> builder)
        {
            builder.HasKey(note => note.Id);
            builder.HasIndex(note => note.Id).IsUnique();
            builder.Property(note => note.Title).HasMaxLength(250);
        }
    }
}
