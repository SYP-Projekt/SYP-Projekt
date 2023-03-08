using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item/Create New Item")]

public class Items : ScriptableObject
{
    public int id;
    public string itemName;
    public int value;
    public Sprite itemIcon;
    public int weight;
    public int limit;
    public int inInventory;
    public float health;
}