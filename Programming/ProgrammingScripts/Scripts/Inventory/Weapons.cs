using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Item/Create New Weapon")]

public class Weapons : ScriptableObject
{
    public int id;
    public string WeaponName;
    public float WeaponDamage;
    public float WeaponSpeed;
    public float WeaponRange;
}
