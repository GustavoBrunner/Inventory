using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumable : Item, IHealth, IDamage, IMana, IUsable, IShowInfo
{
    public int Health { get; set; }
    public int Damage { get; set; }
    public int Mana { get; set; }

    public string[] Info()
    {
        throw new System.NotImplementedException();
    }

    public void Use()
    {

    }
}
