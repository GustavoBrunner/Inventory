using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Item, IDamage, IHealth, IMana, IEquipable, IShowInfo
{
    public int Damage { get; set; }
    public int Health { get; set; }
    public int Mana { get; set; }

    public void Equip()
    {
        
    }

    public string[] Info()
    {
        throw new System.NotImplementedException();
    }
}
