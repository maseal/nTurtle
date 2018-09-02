namespace NTurtle.Core.Interpreter
{
    public class Token
    {
        public Token() : this(TokenType.Unknown, string.Empty, 0, 0, 0, 0)
        {
        }

        public Token(TokenType type, string look, int startRow, int startCol, int endRow, int endCol)
        {
            Type = type;
            Look = look;
            StartRow = startRow;
            StartCol = startCol;
            EndRow = endRow;
            EndCol = endCol;
        }

        public string Look { get; }

        public TokenType Type { get; set; }

        public TokenCategory Category => TokenCategoryFactory.ToCategory(Type);

        public int StartRow { get; set; }

        public int StartCol { get; set; }

        public int EndRow { get; set; }

        public int EndCol { get; set; }

        #region [ Equality ]

        protected bool Equals(Token other)
        {
            return string.Equals(Look, other.Look) && Type == other.Type && StartRow == other.StartRow && StartCol == other.StartCol && EndRow == other.EndRow && EndCol == other.EndCol;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Token) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Look != null ? Look.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (int) Type;
                hashCode = (hashCode * 397) ^ StartRow;
                hashCode = (hashCode * 397) ^ StartCol;
                hashCode = (hashCode * 397) ^ EndRow;
                hashCode = (hashCode * 397) ^ EndCol;
                return hashCode;
            }
        }
        

        #endregion
    }
}