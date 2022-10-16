using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientDecorator : MonoBehaviour
{
    private ChickenDressUp _chickenDressUp;
    private bool _isChickenDecorated;

    public GameObject CowboyHat;
    public GameObject Crown;
    public GameObject MagicianHat;
    public GameObject Mustache;

    void Start()
    {
        _chickenDressUp = (ChickenDressUp)FindObjectOfType(typeof(ChickenDressUp));
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.C))
            CowboyHat.SetActive(!CowboyHat.activeInHierarchy);

        if (Input.GetKeyUp(KeyCode.K))
            Crown.SetActive(!Crown.activeInHierarchy);

        if (Input.GetKeyUp(KeyCode.M))
            MagicianHat.SetActive(!MagicianHat.activeInHierarchy);

        if (Input.GetKeyUp(KeyCode.G))
            Mustache.SetActive(!Mustache.activeInHierarchy);
    }
}
