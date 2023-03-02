using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamage
{
    int Damage { get; set; }
}

public interface IMana
{
    int Mana { get; set; }
}

public interface IHealth
{
    int Health { get; set; }
}

public interface IEquipable
{
    void Equip();
}

public interface IUsable
{
    void Use();
}

public interface IShowInfo
{
    string[] Info();
}
