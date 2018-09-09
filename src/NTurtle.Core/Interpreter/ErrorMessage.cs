namespace NTurtle.Core.Interpreter
{
    public class ErrorMessage
    {
        public ErrorMessage(string text, Token token, ErrorMessageCode code)
        {
            Text = text;
            Token = token;
            Code = code;
        }

        public string Text { get; }
        public Token Token { get; }
        public ErrorMessageCode Code { get; }

        public override string ToString()
        {
            return $"%{Text} [by {Token.Look} on line {Token.StartRow}], code {(int) Code}";
        }

        #region [ Equality ]

        protected bool Equals(ErrorMessage other)
        {
            return string.Equals(Text, other.Text) && Equals(Token, other.Token) && Code == other.Code;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((ErrorMessage) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Text != null ? Text.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Token != null ? Token.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (int) Code;
                return hashCode;
            }
        }

        #endregion
    }
}