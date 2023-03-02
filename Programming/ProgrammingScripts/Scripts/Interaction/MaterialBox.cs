using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaterialBox : Iinteractable
{
    [SerializeField] private string _promt;
    public string InteractionPromt => _promt;

    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape) && PauseMenu.isAtInventory)
        {
            ObjectInventory.INSTANCE.Close();
        }
    }

    public override bool Interact(Interactor interactor)
    {
        ObjectInventory.INSTANCE.ChangeHeadLine("Material Box");
        ObjectInventory.INSTANCE.Open();
        return true;
    }
    public void Close()
    {
        ObjectInventory.INSTANCE.Close();
    }
}
