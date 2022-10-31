using Microsoft.EntityFrameworkCore;
using Notes.Application.Interfaces;
using Notes.Domain;
using Note.Persistence.EntityTypeConfigurations;

namespace Note.Persistence
{
    public class NotesDbContext : DbContext, INotesDbContext
    {
        public DbSet<Notes.Domain.Note> Notes { get; set; }

        public NotesDbContext(DbContextOptions<NotesDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new NoteConfiguration());
            base.OnModelCreating(builder);
        }

    }
}
