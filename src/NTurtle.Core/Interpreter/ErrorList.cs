using System.Collections.Generic;

namespace NTurtle.Core.Interpreter
{
    public class ErrorList : List<ErrorMessage>
    {
        public void AddError(string text, Token token, ErrorMessageCode code)
        {
            ErrorMessage error = new ErrorMessage(text, token, code);
            AddError(error);
        }

        public void AddError(ErrorMessage error)
        {
            if (!Contains(error))
                this.Add(error);
        }

        public IList<string> ToStringList()
        {
            List<string> result = new List<string>();
            for (int i = 0; i < this.Count; i++)
            {
                result.Add($"{i}: {this[i]}");
            }

            return result;
        }
    }
}