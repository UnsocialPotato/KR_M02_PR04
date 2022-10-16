using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenDressUp : MonoBehaviour
{
    public ChickenConfig chickenConfig;
    public ChickenAttachment hatAttachment;
    public ChickenAttachment wingAttachment;

    private IChicken _chicken;
    private bool _isDecorated;

    void Start()
    {
        _chicken = new Chicken(chickenConfig);
    }

    public void Reset()
    {
        _chicken = new Chicken(chickenConfig);
        _isDecorated = !_isDecorated;
    }

    public void Decorate()
    {
        if (hatAttachment && !wingAttachment)
            _chicken = new ChickenDecorator(_chicken, hatAttachment);

        if (hatAttachment && wingAttachment)
            _chicken = new ChickenDecorator(new ChickenDecorator(_chicken, hatAttachment),wingAttachment);

        _isDecorated = !_isDecorated;
    }
}
