using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Equipment", menuName ="Inventory/Equipment")]
public class Equipment : Item
{
    public EquipmentSlot equipSlot;
    public int armorModifier;
    public int demageModifier;

    public override void Use(){
        base.Use();
        Inventory.instance.Equip(this);
        
    }
}

public enum EquipmentSlot {Head, Chest, Legs, Boots, Weapon}