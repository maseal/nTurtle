namespace NTurtle.Core.Interpreter
{
    public class TokenCategoryFactory
    {
        public static TokenCategory ToCategory(TokenType type)
        {
            switch (type)
            {
                case TokenType.Mod:
                case TokenType.Sin:
                case TokenType.GoY:
                case TokenType.FontSize:
                case TokenType.GoX:
                case TokenType.GetDirection:
                case TokenType.Cos:
                case TokenType.CanvasColor:
                case TokenType.Tan:
                case TokenType.Backward:
                case TokenType.CanvasSize:
                case TokenType.TurnRight:
                case TokenType.Pi:
                case TokenType.Forward:
                case TokenType.Message:
                case TokenType.Random:
                case TokenType.Sqrt:
                case TokenType.Go:
                case TokenType.ArcSin:
                case TokenType.Ask:
                case TokenType.Assert:
                case TokenType.PenUp:
                case TokenType.Print:
                case TokenType.Clear:
                case TokenType.ArcCos:
                case TokenType.SpriteHide:
                case TokenType.TurnLeft:
                case TokenType.PenWidth:
                case TokenType.Direction:
                case TokenType.ArcTan:
                case TokenType.SpriteShow:
                case TokenType.Center:
                case TokenType.Round:
                case TokenType.GetX:
                case TokenType.GetY:
                case TokenType.PenColor:
                case TokenType.PenDown:
                case TokenType.Reset:
                    return TokenCategory.CommandCategory;

                case TokenType.Else:
                case TokenType.Break:
                case TokenType.Return:
                case TokenType.While:
                case TokenType.Step:
                case TokenType.For:
                case TokenType.Wait:
                case TokenType.ForTo:
                case TokenType.Repeat:
                case TokenType.To:
                case TokenType.Exit:
                case TokenType.If:
                    return TokenCategory.ControllerCommandCategory;

                case TokenType.Number:
                    return TokenCategory.NumberCategory;

                case TokenType.ParenthesisOpen:
                case TokenType.ParenthesisClose:
                    return TokenCategory.ParenthesisCategory;

                case TokenType.True:
                case TokenType.False:
                    return TokenCategory.TrueFalseCategory;

                case TokenType.FunctionCall:
                    return TokenCategory.FunctionCallCategory;

                case TokenType.GreaterThan:
                case TokenType.LessOrEquals:
                case TokenType.Equals:
                case TokenType.LessThan:
                case TokenType.GreaterOrEquals:
                case TokenType.NotEquals:
                    return TokenCategory.ExpressionCategory;

                case TokenType.ArgumentSeparator:
                    return TokenCategory.ArgumentSeparatorCategory;

                case TokenType.Power:
                case TokenType.Substracton:
                case TokenType.Multiplication:
                case TokenType.Division:
                case TokenType.Addition:
                    return TokenCategory.MathOperatorCategory;

                case TokenType.Comment:
                    return TokenCategory.CommentCategory;

                case TokenType.Assign:
                    return TokenCategory.AssignmentCategory;

                case TokenType.Or:
                case TokenType.And:
                case TokenType.Not:
                    return TokenCategory.BooleanOperatorCategory;

                case TokenType.Scope:
                case TokenType.ScopeOpen:
                case TokenType.ScopeClose:
                    return TokenCategory.ScopeCategory;

                case TokenType.Variable:
                    return TokenCategory.VariableCategory;

                case TokenType.StringDelimiter:
                case TokenType.String:
                    return TokenCategory.StringCategory;

                case TokenType.Learn:
                    return TokenCategory.LearnCommandCategory;
                default:
                    return TokenCategory.UnknownCategory;
            }
        }
    }
}