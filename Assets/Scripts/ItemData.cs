using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ItemData : ScriptableObject
{
    public string _name;
    [MultiLineProperty]
    public string _description;
    [PreviewField(50, ObjectFieldAlignment.Center)]
    public Sprite _icon;
    public ItemType _itemType;
}

[Flags]
public enum ItemType
{
    Resources = 1 << 0,
    Food = 1 << 1,
    Plantable = 1 << 2,
    Hat = 1 << 3,
    Dress = 1 << 4,
    Armor = 1 << 5,
    Bag = 1 << 6,
    Tool = 1 << 7,
    MeleeWeapon = 1 << 8,

}
