using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerCombat : MonoBehaviour {
    
    public Transform position;


    public void attack(){
        var weapon = (Weapon)Inventory.instance.currentItems[(int)EquipmentSlot.Weapon];
        if(weapon != null){
            weapon.Attack(position);
        }
    }

}
