using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBox : Iinteractable
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
        ObjectInventory.INSTANCE.ChangeHeadLine("Weapon Box");
        ObjectInventory.INSTANCE.Open();
        return true;
    }
    public void Close()
    {
        ObjectInventory.INSTANCE.Close();
    }
}
