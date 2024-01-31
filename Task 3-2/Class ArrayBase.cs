using System;
public abstract class ArrayBase
{
    protected abstract void InputArray();
    protected abstract void RandomArray();
    protected abstract void CreateArray(bool userValues = false);
    public abstract void Average();
    public abstract void Print();
    public abstract void Recreate(bool userValues = false);
}