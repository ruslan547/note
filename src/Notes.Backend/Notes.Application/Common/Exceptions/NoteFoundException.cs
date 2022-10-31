using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Application.Common.Exceptions
{
    public class NoteFoundException : Exception
    {
        public NoteFoundException(string name, object key) : base($"Entity \"{name}\"({ key }) not found.")
        {

        }
    }
}
