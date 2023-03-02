using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadGear : Item, IDamage, IMana, IEquipable, IShowInfo
{
    public int Damage { get; set; }
    public int Mana { get; set; }

    public void Equip()
    {

    }

    public string[] Info()
    {
        throw new System.NotImplementedException();
    }
}
