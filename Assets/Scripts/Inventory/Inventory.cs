using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
 #region Singleton
    public static Inventory instance;

    void Awake (){
        if(instance != null){
            Debug.LogWarning("More than one instance of Inventory found!");
        }
        instance = this;
    }
    #endregion
    
    public Equipment[] currentItems;

    void Start(){
        currentItems = new Equipment[System.Enum.GetNames(typeof(EquipmentSlot)).Length];
    }

    public void Equip(Equipment newItem){
        int slotIndex = (int)newItem.equipSlot;

        if(currentItems[slotIndex] != null){
            currentItems[slotIndex].itemPickup.setActive(true);
        }

        currentItems[slotIndex] = newItem;
    }
}
