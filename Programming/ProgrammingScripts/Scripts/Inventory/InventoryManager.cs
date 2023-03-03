using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using TMPro;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager INSTANCE;
    public List<Items> itemlist = new List<Items>();

    public Transform ItemContent;
    public GameObject InventoryItem;

    public GameObject InventoryUI;
    public GameObject Crosshair;
    public GameObject MiniMAP;

    public TMP_Text addedUI;
    public static int weight = 0;

    //setting instance
    private void Awake()
    {
        INSTANCE = this;
    }


    //List
    public void Add(Items item)
    {
        addedUI.text = "added " + item.value + " "+ item.itemName + "!";

        weight += item.weight;
        Debug.Log(weight);
        if(itemlist != null)
        {
            foreach(var i in itemlist)
            {
                if(i.id == item.id)
                {
                    i.inInventory += item.value;
                    return;
                }
            }
        }
        item.inInventory = item.value;
        itemlist.Add(item);

    }
    public void Delete(Items item)
    {
        itemlist.Remove(item);
        weight -= item.weight;
    }

    public void ListItems()
    {
        //Clean
        foreach(Transform item in ItemContent)
        {
            Destroy(item.gameObject);
        }

        //Add
        foreach (var item in itemlist)
        {
            GameObject obj = Instantiate(InventoryItem, ItemContent);
            var itemName = obj.transform.Find("ItemName").GetComponent<TMP_Text>();
            var itemIcon = obj.transform.Find("ItemIcon").GetComponent<Image>();
            var itemValue = obj.transform.Find("ItemValue").GetComponent<TMP_Text>();

            itemName.text = item.itemName;
            itemIcon.sprite = item.itemIcon;
            itemValue.text = item.inInventory.ToString();
        }
    }

    //Visual
    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.I))
        {
            this.Open();
        } else if(Input.GetKeyUp(KeyCode.Escape))
        {
            this.Close();
        }
    }
    public void Open()
    {
        InventoryUI.SetActive(true);
        Crosshair.SetActive(false);
        MiniMAP.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0f;
        this.ListItems();
    }
    public void Close()
    {
        InventoryUI.SetActive(false);
        Crosshair.SetActive(true);
        MiniMAP.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
    }

}
