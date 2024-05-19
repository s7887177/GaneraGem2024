
using UnityEngine;

public interface IPositionProvider
{
    Vector3 position { get; }
}
public interface ITextProvider
{
    string text { get; }
}