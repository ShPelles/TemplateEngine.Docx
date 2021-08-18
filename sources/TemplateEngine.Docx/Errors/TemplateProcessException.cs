using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateEngine.Docx.Errors
{

    [Serializable]
    public class TemplateProcessException : Exception
    {
        public IEnumerable<string> Errors { get; private set; }

        //public TemplateProcessException() { }
        internal TemplateProcessException(IList<IError> errors) : base("An error occurs during the template processing")
        {
            Errors = errors.Select(error => error.Message);
        }
        //public TemplateProcessException(string message, Exception inner) : base(message, inner) { }
        protected TemplateProcessException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
