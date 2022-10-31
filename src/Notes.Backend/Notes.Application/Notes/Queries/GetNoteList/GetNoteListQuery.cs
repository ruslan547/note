using System;
using MediatR;

namespace Notes.Application.Notes.Queries.GetNoteList
{
    public class GetNoteListQuery : IRequest<NoteListVm>
    {
        public Guid UserId { get; set; }
        public string Title { get; set; }
    }
}
