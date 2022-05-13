using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Equipment", menuName ="Inventory/Weapon")]
public class Weapon : Equipment
{
    public int range;
    public WeaponAttack weaponAttack;
    public int attackSpeed;

    public Weapon(){
        base.equipSlot = EquipmentSlot.Weapon;
    }

    public void Attack(Transform position){
        //this.weaponAttack.Attack(position, this.range);
    }

    public override void Use(){
        base.Use();
    }
}
