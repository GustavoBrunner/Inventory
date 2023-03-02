using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    //LISTS INVENTARIO
    public List<IEquipable> Equips;
    public List<Item> Slots;

    //EQUIPAVEIS
    public HeadGear Head { get { return Equips[0] as HeadGear; } }
    public BodyGear Body { get { return Equips[1] as BodyGear; } }
    public Weapon Weapon { get { return Equips[2] as Weapon; } }
    public FeetGear Feet { get { return Equips[3] as FeetGear; } }
    
    //STATS DE VIDA TOTAL
    public int HealthConsumable { get; set; }
    public int Health
    {
        get
        {
            return
            (
                Weapon.Health +
                Body.Health +
                Feet.Health +
                HealthConsumable
            );
        }
    }

    //STATS DE MANA TOTAL
    public int ManaConsumable { get; set; }
    public int Mana
    {
        get
        {
            return
            (
                Weapon.Mana +
                Head.Mana +
                Body.Mana +
                Feet.Mana +
                ManaConsumable
            );
        }
    
    }

    //STATS DE DANO TOTAL
    public int DamageConsumable { get; set; }
    public int Damage
    {
        get
        {
            return
            (
                Weapon.Damage +
                Head.Damage +
                DamageConsumable
            );
        }
    }

    private void Awake()
    {
        Equips = new List<IEquipable>(4);
        Slots = new List<Item>(18);
    }

}
