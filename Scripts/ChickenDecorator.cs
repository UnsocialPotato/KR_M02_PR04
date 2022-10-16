using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenDecorator : IChicken
{
    private readonly IChicken _decoratedChicken;
    private readonly ChickenAttachment _attachment;

    public ChickenDecorator (IChicken chicken, ChickenAttachment attachment)
    {
        _attachment = attachment;
        _decoratedChicken = chicken;
    }

    public float Strength
    {
        get { return _decoratedChicken.Strength + _attachment.Strength; }
    }

    public float Swag
    {
        get { return _decoratedChicken.Swag + _attachment.Swag; }
    }
}
