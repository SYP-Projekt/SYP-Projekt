using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Iinteractable : MonoBehaviour
{
    public string InteractionPromt { get; }

    public abstract bool Interact(Interactor interactor);
}
