using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewChickenConfig",menuName = "Chicken/Config", order = 1)]
public class ChickenConfig : ScriptableObject, IChicken
{
    [Range(0, 100)]
    [Tooltip("Chicken strength")]
    [SerializeField] private float strength;

    [Range(0, 100)]
    [Tooltip("Chicken SWAG")]
    [SerializeField] private float swag;

    public float Strength
    {
        get { return strength; }
    }

    public float Swag
    {
        get { return swag; }
    }
}
