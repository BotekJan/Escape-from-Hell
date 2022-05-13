using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicSwordAttack : WeaponAttack
{


    public override void Attack(Transform position, int range){
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(position.position, range);

        foreach(Collider2D enemy in hitEnemies){
            Debug.Log("hit something with basic sword");
        }
    }
}
