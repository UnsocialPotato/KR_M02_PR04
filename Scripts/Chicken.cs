using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : IChicken
{
    public float Strength
    {
        get { return _config.Strength; }
    }

    public float Swag
    {
        get { return _config.Swag; }
    }

    private readonly ChickenConfig _config;

    public Chicken(ChickenConfig chickenConfig)
    {
        _config = chickenConfig;
    }
}
