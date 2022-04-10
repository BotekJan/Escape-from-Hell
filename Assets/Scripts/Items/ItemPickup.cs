using UnityEngine;

public class ItemPickup : Interactable
{
    public GameObject myObject;
    public Item item;
    public override void Interact(){
        base.Interact();

        PickUp();
    }

    void Start(){
        if(item == null){
            Debug.LogError("No item set for this itemPickup!");
        }

        item.itemPickup = this;
    }

    void PickUp(){
        Debug.Log("Picking up " + item.name);
        if(item.GetType() == typeof(Equipment)){
            Inventory.instance.Equip((Equipment)item);
        }
        else{
            item.Use();
        }
        myObject.SetActive(false);
    }

    public void setActive(bool active){
        myObject.SetActive(active);
    }
}
