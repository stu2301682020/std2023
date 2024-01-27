using System;

public class MyPair<T, V>
{

    public T Key { get; set; }
    public V Value { get; set; }

    public MyPair(T key, V value)
    {
        Key = key;
        Value = value;
    }


    public override string ToString()
    {
        return $"({Key}:{Value})";
    }
}
