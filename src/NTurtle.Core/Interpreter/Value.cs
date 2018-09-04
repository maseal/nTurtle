namespace NTurtle.Core.Interpreter
{
    public class Value
    {
        void Init()
        {
            _type = ValueType.Empty;
            _boolValue = false;
            _doubleValue = 0;
            _stringValue = string.Empty;
        }
        
        ValueType _type;
        bool _boolValue;
        double _doubleValue;
        string  _stringValue;
    }
}