using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public static WeaponController INSTANCE;
    public Weapons weapon;

    private void Awake()
    {
        INSTANCE = this;
    }
    public float getDamage()
    {
       // if(weapon == null)
        //{
            return 5f;
       // }
       // return weapon.WeaponDamage;
    }
    public void selectWeapon(Weapons weapon)
    {
        this.weapon = weapon;
    }
}
