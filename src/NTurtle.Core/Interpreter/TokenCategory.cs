namespace NTurtle.Core.Interpreter
{
    public enum TokenCategory
    {
        UnknownCategory,
        CommandCategory,
        ControllerCommandCategory,
        NumberCategory,
        ParenthesisCategory,
        TrueFalseCategory,
        FunctionCallCategory,
        ExpressionCategory,
        ArgumentSeparatorCategory,
        MathOperatorCategory,
        CommentCategory,
        AssignmentCategory,
        BooleanOperatorCategory,
        ScopeCategory,
        VariableCategory,
        StringCategory,
        LearnCommandCategory
    }
}