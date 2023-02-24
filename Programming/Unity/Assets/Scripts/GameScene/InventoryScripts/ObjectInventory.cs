using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ObjectInventory : MonoBehaviour
{
    public GameObject inventory;
    public static ObjectInventory INSTANCE;
    public Text headline;

    public void Close()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
        inventory.SetActive(false);
        PauseMenu.isAtInventory = false;
    }
    public void Open()
    {
        PauseMenu.isAtInventory = true;
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0f;
        inventory.SetActive(true);
    }

    public void ChangeHeadLine(string text)
    {
        headline.text = text;
    }

    public ObjectInventory()
    {
        INSTANCE = this;
    }
}
