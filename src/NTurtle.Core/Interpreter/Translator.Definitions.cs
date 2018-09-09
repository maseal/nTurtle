using NGettext;

namespace NTurtle.Core.Interpreter
{
    public partial class Translator
    {
        private void FillTranslatedDictionary(Catalog localizer)
        {
            string localizedCommandLook;

            lookToTypeMap["$"] = TokenType.VariablePrefix;

            localizedCommandLook = GetLocalized(
                "true", localizer);
            defaultToLocalizedMap["true"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.True;

            localizedCommandLook = GetLocalized(
                "false", localizer);
            defaultToLocalizedMap["false"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.False;

            lookToTypeMap["#"] = TokenType.Comment;

            lookToTypeMap["\""] = TokenType.StringDelimiter;

            lookToTypeMap["{"] = TokenType.ScopeOpen;

            lookToTypeMap["}"] = TokenType.ScopeClose;

            lookToTypeMap["("] = TokenType.ParenthesisOpen;

            lookToTypeMap[")"] = TokenType.ParenthesisClose;

            localizedCommandLook = GetLocalized(
                ",", localizer);
            defaultToLocalizedMap[","] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.ArgumentSeparator;

            localizedCommandLook = GetLocalized(
                ".", localizer);
            defaultToLocalizedMap["."] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.DecimalSeparator;

            localizedCommandLook = GetLocalized(
                "exit", localizer);
            defaultToLocalizedMap["exit"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.Exit;

            localizedCommandLook = GetLocalized(
                "if", localizer);
            defaultToLocalizedMap["if"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.If;

            localizedCommandLook = GetLocalized(
                "else", localizer);
            defaultToLocalizedMap["else"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.Else;

            localizedCommandLook = GetLocalized(
                "repeat", localizer);
            defaultToLocalizedMap["repeat"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.Repeat;

            localizedCommandLook = GetLocalized(
                "while", localizer);
            defaultToLocalizedMap["while"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.While;

            localizedCommandLook = GetLocalized(
                "for", localizer);
            defaultToLocalizedMap["for"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.For;

            localizedCommandLook = GetLocalized(
                "to", localizer);
            defaultToLocalizedMap["to"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.To;

            localizedCommandLook = GetLocalized(
                "step", localizer);
            defaultToLocalizedMap["step"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.Step;

            localizedCommandLook = GetLocalized(
                "break", localizer);
            defaultToLocalizedMap["break"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.Break;

            localizedCommandLook = GetLocalized(
                "return", localizer);
            defaultToLocalizedMap["return"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.Return;

            localizedCommandLook = GetLocalized(
                "wait", localizer);
            defaultToLocalizedMap["wait"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.Wait;

            localizedCommandLook = GetLocalized(
                "assert", localizer);
            defaultToLocalizedMap["assert"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.Assert;

            localizedCommandLook = GetLocalized(
                "and", localizer);
            defaultToLocalizedMap["and"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.And;

            localizedCommandLook = GetLocalized(
                "or", localizer);
            defaultToLocalizedMap["or"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.Or;

            localizedCommandLook = GetLocalized(
                "not", localizer);
            defaultToLocalizedMap["not"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.Not;

            lookToTypeMap["=="] = TokenType.Equals;

            lookToTypeMap["!="] = TokenType.NotEquals;

            lookToTypeMap[">"] = TokenType.GreaterThan;

            lookToTypeMap["<"] = TokenType.LessThan;

            lookToTypeMap[">="] = TokenType.GreaterOrEquals;

            lookToTypeMap["<="] = TokenType.LessOrEquals;

            lookToTypeMap["+"] = TokenType.Addition;

            lookToTypeMap["-"] = TokenType.Substracton;

            lookToTypeMap["*"] = TokenType.Multiplication;

            lookToTypeMap["/"] = TokenType.Division;

            lookToTypeMap["^"] = TokenType.Power;

            lookToTypeMap["="] = TokenType.Assign;

            localizedCommandLook = GetLocalized(
                "learn", localizer);
            defaultToLocalizedMap["learn"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.Learn;

            localizedCommandLook = GetLocalized(
                "reset", localizer);
            defaultToLocalizedMap["reset"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.Reset;

            localizedCommandLook = GetLocalized(
                "clear", localizer);
            defaultToLocalizedMap["clear"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.Clear;

            localizedCommandLook = GetLocalized(
                "ccl", localizer);
            defaultToLocalizedMap["ccl"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.Clear;

            localizedCommandLook = GetLocalized(
                "center", localizer);
            defaultToLocalizedMap["center"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.Center;

            localizedCommandLook = GetLocalized(
                "go", localizer);
            defaultToLocalizedMap["go"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.Go;

            localizedCommandLook = GetLocalized(
                "gox", localizer);
            defaultToLocalizedMap["gox"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.GoX;

            localizedCommandLook = GetLocalized(
                "gx", localizer);
            defaultToLocalizedMap["gx"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.GoX;

            localizedCommandLook = GetLocalized(
                "goy", localizer);
            defaultToLocalizedMap["goy"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.GoY;

            localizedCommandLook = GetLocalized(
                "gy", localizer);
            defaultToLocalizedMap["gy"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.GoY;

            localizedCommandLook = GetLocalized(
                "forward", localizer);
            defaultToLocalizedMap["forward"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.Forward;

            localizedCommandLook = GetLocalized(
                "fw", localizer);
            defaultToLocalizedMap["fw"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.Forward;

            localizedCommandLook = GetLocalized(
                "backward", localizer);
            defaultToLocalizedMap["backward"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.Backward;

            localizedCommandLook = GetLocalized(
                "bw", localizer);
            defaultToLocalizedMap["bw"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.Backward;

            localizedCommandLook = GetLocalized(
                "direction", localizer);
            defaultToLocalizedMap["direction"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.Direction;

            localizedCommandLook = GetLocalized(
                "dir", localizer);
            defaultToLocalizedMap["dir"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.Direction;

            localizedCommandLook = GetLocalized(
                "turnleft", localizer);
            defaultToLocalizedMap["turnleft"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.TurnLeft;

            localizedCommandLook = GetLocalized(
                "tl", localizer);
            defaultToLocalizedMap["tl"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.TurnLeft;

            localizedCommandLook = GetLocalized(
                "turnright", localizer);
            defaultToLocalizedMap["turnright"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.TurnRight;

            localizedCommandLook = GetLocalized(
                "tr", localizer);
            defaultToLocalizedMap["tr"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.TurnRight;

            localizedCommandLook = GetLocalized(
                "penwidth", localizer);
            defaultToLocalizedMap["penwidth"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.PenWidth;

            localizedCommandLook = GetLocalized(
                "pw", localizer);
            defaultToLocalizedMap["pw"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.PenWidth;

            localizedCommandLook = GetLocalized(
                "penup", localizer);
            defaultToLocalizedMap["penup"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.PenUp;

            localizedCommandLook = GetLocalized(
                "pu", localizer);
            defaultToLocalizedMap["pu"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.PenUp;

            localizedCommandLook = GetLocalized(
                "pendown", localizer);
            defaultToLocalizedMap["pendown"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.PenDown;

            localizedCommandLook = GetLocalized(
                "pd", localizer);
            defaultToLocalizedMap["pd"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.PenDown;

            localizedCommandLook = GetLocalized(
                "pencolor", localizer);
            defaultToLocalizedMap["pencolor"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.PenColor;

            localizedCommandLook = GetLocalized(
                "pc", localizer);
            defaultToLocalizedMap["pc"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.PenColor;

            localizedCommandLook = GetLocalized(
                "canvascolor", localizer);
            defaultToLocalizedMap["canvascolor"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.CanvasColor;

            localizedCommandLook = GetLocalized(
                "cc", localizer);
            defaultToLocalizedMap["cc"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.CanvasColor;

            localizedCommandLook = GetLocalized(
                "canvassize", localizer);
            defaultToLocalizedMap["canvassize"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.CanvasSize;

            localizedCommandLook = GetLocalized(
                "cs", localizer);
            defaultToLocalizedMap["cs"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.CanvasSize;

            localizedCommandLook = GetLocalized(
                "spriteshow", localizer);
            defaultToLocalizedMap["spriteshow"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.SpriteShow;

            localizedCommandLook = GetLocalized(
                "ss", localizer);
            defaultToLocalizedMap["ss"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.SpriteShow;

            localizedCommandLook = GetLocalized(
                "spritehide", localizer);
            defaultToLocalizedMap["spritehide"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.SpriteHide;

            localizedCommandLook = GetLocalized(
                "sh", localizer);
            defaultToLocalizedMap["sh"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.SpriteHide;

            localizedCommandLook = GetLocalized(
                "print", localizer);
            defaultToLocalizedMap["print"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.Print;

            localizedCommandLook = GetLocalized(
                "fontsize", localizer);
            defaultToLocalizedMap["fontsize"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.FontSize;

            localizedCommandLook = GetLocalized(
                "random", localizer);
            defaultToLocalizedMap["random"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.Random;

            localizedCommandLook = GetLocalized(
                "rnd", localizer);
            defaultToLocalizedMap["rnd"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.Random;

            localizedCommandLook = GetLocalized(
                "getx", localizer);
            defaultToLocalizedMap["getx"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.GetX;

            localizedCommandLook = GetLocalized(
                "gety", localizer);
            defaultToLocalizedMap["gety"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.GetY;

            localizedCommandLook = GetLocalized(
                "message", localizer);
            defaultToLocalizedMap["message"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.Message;

            localizedCommandLook = GetLocalized(
                "ask", localizer);
            defaultToLocalizedMap["ask"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.Ask;

            localizedCommandLook = GetLocalized(
                "pi", localizer);
            defaultToLocalizedMap["pi"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.Pi;

            localizedCommandLook = GetLocalized(
                "tan", localizer);
            defaultToLocalizedMap["tan"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.Tan;

            localizedCommandLook = GetLocalized(
                "sin", localizer);
            defaultToLocalizedMap["sin"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.Sin;

            localizedCommandLook = GetLocalized(
                "cos", localizer);
            defaultToLocalizedMap["cos"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.Cos;

            localizedCommandLook = GetLocalized(
                "arctan", localizer);
            defaultToLocalizedMap["arctan"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.ArcTan;

            localizedCommandLook = GetLocalized(
                "arcsin", localizer);
            defaultToLocalizedMap["arcsin"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.ArcSin;

            localizedCommandLook = GetLocalized(
                "arccos", localizer);
            defaultToLocalizedMap["arccos"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.ArcCos;

            localizedCommandLook = GetLocalized(
                "sqrt", localizer);
            defaultToLocalizedMap["sqrt"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.Sqrt;

            localizedCommandLook = GetLocalized(
                "round", localizer);
            defaultToLocalizedMap["round"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.Round;

            localizedCommandLook = GetLocalized(
                "getdirection", localizer);
            defaultToLocalizedMap["getdirection"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.GetDirection;

            localizedCommandLook = GetLocalized(
                "mod", localizer);
            defaultToLocalizedMap["mod"] = localizedCommandLook;
            lookToTypeMap[localizedCommandLook] = TokenType.Mod;
        }
    }
}