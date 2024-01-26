using System;
public abstract class ArrayBase
{
    public abstract void Average();
    public abstract void InputArray();
    public abstract void RandomArray();
    public abstract void Print();
    public abstract void CreateArray(int size, bool userValues = false);
    public abstract void CreateArray(int line, int column, bool userValues = false);
}