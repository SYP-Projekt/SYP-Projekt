using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tree : Iinteractable
{

    [SerializeField] private string _promt;
    public string InteractionPromt => _promt;
    public override bool Interact(Interactor interactor)
    {
        Debug.Log("Cutting tree!");
        return true;
    }
}
