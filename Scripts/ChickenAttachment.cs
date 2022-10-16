using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewChickenAttachment", menuName = "Chicken/Attachment", order = 1)]
public class ChickenAttachment : ScriptableObject, IChicken
{
    [Tooltip("Increase weapon strength")]
    [SerializeField] public float strength;

    [Tooltip("Increase weapon SWAG")]
    [SerializeField] public float swag;

    public float Strength
    {
        get { return strength; }
    }

    public float Swag
    {
        get { return swag; }
    }
}
