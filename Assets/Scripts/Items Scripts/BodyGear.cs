using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyGear : Item, IHealth, IMana, IEquipable, IShowInfo
{
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
