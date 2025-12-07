using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDataStrucsAlgos.DesignPatterns.Behavioral;

/// <summary>
/// Intent: Define a representation for a language’s grammar along with an interpreter that uses the representation to interpret sentences in the language.
/// Usage in .NET: Building rule engines or simple expression evaluators.
/// </summary>

public abstract class Expression {
    public abstract int Interpret();
}

public class NumberExpression : Expression {
    private readonly int _number;
    public NumberExpression(int number) { _number = number; }
    public override int Interpret() => _number;
}

public class AddExpression : Expression {
    private readonly Expression _left, _right;
    public AddExpression(Expression left, Expression right) {
        _left = left;
        _right = right;
    }
    public override int Interpret() => _left.Interpret() + _right.Interpret();
}

