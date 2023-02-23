using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower1 : Iinteractable
{
    [SerializeField] private string _promt;
    public string InteractionPromt => _promt;
    public override bool Interact(Interactor interactor)
    {
        Debug.Log("Press E to Pickup!");
        return true;
    }
}
