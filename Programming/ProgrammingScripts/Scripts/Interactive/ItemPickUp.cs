using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Search;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    #region Variables
    public GameObject Player;
    public Items item;

    public float distance = 1000f;

    Vector3 playerPosition;
    Vector3 objectPosition;

    public float radius = 5.0f;

    float health = -1f;

    WeaponController weaponController = new WeaponController();

    #endregion

    void Pickup()
    {
        InventoryManager.INSTANCE.Add(item);
        Destroy(gameObject);
    }
    private void OnMouseOver()
    {
        if(health == -1f)
        {
            health = this.item.health;
        }
        playerPosition = Player.transform.position;
        objectPosition = gameObject.transform.position;

        distance = Vector3.Distance(objectPosition, playerPosition);

        if ((Input.GetKeyUp(KeyCode.E) && distance < radius) && health == 0)
        {
            this.Pickup();
        }

        if((distance < radius && health > 0) && Input.GetMouseButtonUp(0))
        {
            health = health - weaponController.getDamage();
            Debug.Log(health);
        }
        if(health < 0)
        {
            this.Pickup();
        }
    }
}
