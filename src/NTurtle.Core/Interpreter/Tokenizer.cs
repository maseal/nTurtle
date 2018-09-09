using NTurtle.Core.Extensions;

namespace NTurtle.Core.Interpreter
{
    public class Tokenizer
    {
        public void Initialize(string inString)
        {
            translator = Translator.Instance;
            inputString = inString + '\n'; // the certainty of a hard break at the end makes parsing much easier
            at = 0;
            row = 1;
            col = 1;
            prevCol = 1;
            atEnd = false;
        }

        public Token GetToken()
        {
            int startRow = row;
            int startCol = col;

            char c = GetChar(); // get and store the next character from the string

            // catch the end of the input string
            if (atEnd)
                return new Token(TokenType.EndOfInput, "END", row, col, row, col);

            TokenType charTokenType = translator.LookToType(c); // since we need to know it often we store it

            string look = string.Empty;
            // catch spaces
            if (c.IsWhiteSpace())
            {
                do
                {
                    look += c.IsTab() ? "  " : " ";
                    c = GetChar();
                } while (c.IsWhiteSpace() && !atEnd);

                UngetChar();
                return new Token(TokenType.WhiteSpace, look, startRow, startCol, row, col);
            }

            // catch EndOfLine's
            if (c.IsBreak())
            {
                return new Token(TokenType.EndOfLine, "\\n", startRow, startCol, startRow + 1, 1);
            }

            // catch comments
            if (charTokenType == TokenType.Comment)
            {
                do
                {
                    look += c;
                    c = GetChar();
                } while (!c.IsBreak() && !atEnd);

                UngetChar();
                return new Token(TokenType.Comment, look, startRow, startCol, row, col);
            }

            // catch strings
            if (charTokenType == TokenType.StringDelimiter)
            {
                look += c;
                do
                {
                    c = GetChar();
                    look += c;
                } while (
                    !(translator.LookToType(c) == TokenType.StringDelimiter && !look.EndsWith("\\\"")) &&
                    !c.IsBreak() && !atEnd);

                return new Token(TokenType.String, look, startRow, startCol, row, col);
            }

            // catch variables
            if (charTokenType == TokenType.VariablePrefix)
            {
                do
                {
                    look += c;
                    c = GetChar();
                } while (c.IsWordChar() || c.IsDigit() || c == '_');

                UngetChar();
                return new Token(TokenType.Variable, look, startRow, startCol, row, col);
            }

            // catch words (known commands or function calls)
            if (c.IsWordChar())
            {
                do
                {
                    look += c;
                    c = GetChar();
                } while (c.IsWordChar() || c.IsDigit() || c == '_'); // next chars

                UngetChar();
                var type = translator.LookToType(look);
                if (type == TokenType.Unknown)
                    type = TokenType.FunctionCall;
                return new Token(type, look, startRow, startCol, row, col);
            }

            // catch numbers
            if (c.IsDigit() || charTokenType == TokenType.DecimalSeparator)
            {
                bool hasDot = false;
                var localType = charTokenType;
                do
                {
                    if (localType == TokenType.DecimalSeparator) hasDot = true;
                    look += c;
                    c = GetChar();
                    localType = translator.LookToType(c);
                } while (c.IsDigit() || localType == TokenType.DecimalSeparator && !hasDot);

                UngetChar();

                // if all we got is a dot then this is not a number, so return an Error token here
                if (translator.LookToType(look) == TokenType.DecimalSeparator)
                    return new Token(TokenType.Error, look, startRow, startCol, row, col);

                return new Token(TokenType.Number, look, startRow, startCol, row, col);
            }

            // catch previously uncatched 'double charactered tokens' (tokens that ar not in letters, like: == != >= <=)
            {
                look += c;
                look += GetChar();
                var type = translator.LookToType(look);
                if (type != TokenType.Unknown)
                    return new Token(type, look, startRow, startCol, row, col);
                UngetChar();
            }

            // catch known tokens of a single character (as last...)
            if (charTokenType != TokenType.Unknown)
                return new Token(charTokenType, c.ToString(), startRow, startCol, row, col);

            // this does not neglect calls to functions with a name of length one (checked it)
            return new Token(TokenType.Error, c.ToString(), startRow, startCol, row, col);
        }

        private char GetChar()
        {
            if (at >= inputString.Length)
            {
                atEnd = true;
                return '\0';
            }

            var c = inputString[at];
            at++;
            if (c.IsBreak())
            {
                row++;
                prevCol = col;
                col = 1;
            }
            else
            {
                col++;
            }

            return c;
        }


        private void UngetChar()
        {
            if (at <= 0)
                return;

            at--;
            if (atEnd) atEnd = false;

            var c = inputString[at];
            if (c.IsBreak())
            {
                row--;
                col = prevCol;
            }
            else
            {
                col--;
            }
        }

        private Translator translator;
        private string inputString;

        private int at, row, col, prevCol;
        private bool atEnd; // true if the inputString is fully tokenized
    }
}