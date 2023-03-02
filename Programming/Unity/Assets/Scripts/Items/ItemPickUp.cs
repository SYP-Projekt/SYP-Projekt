using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Search;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public GameObject Player;
    public Items item;

    public float distance;

    Vector3 playerPosition;
    Vector3 objectPosition;

    public float radius = 5.0f;

    float health;

    private void Awake()
    {
        this.health = item.health;
    }

    void Pickup()
    {
        InventoryManager.INSTANCE.Add(item);
        Destroy(gameObject);
    }

    private void OnMouseOver()
    {
        playerPosition = Player.transform.position;
        objectPosition = gameObject.transform.position;

        distance = Vector3.Distance(objectPosition, playerPosition);
        if((Input.GetKeyUp(KeyCode.E) && distance < radius) && health == 0)
        {
            this.Pickup();
        }

        if((distance < radius && health > 0) && Input.GetMouseButton(0))
        {
            Debug.Log("Working");
            health = health - WeaponController.INSTANCE.getDamage();
        }

        if(health <= 0)
        {
            Debug.Log("We did it");
            this.Pickup();
        }
    }



}
