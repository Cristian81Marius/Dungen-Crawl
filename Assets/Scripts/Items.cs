using System.Collections;
using System.Collections.Generic;
using System.IO.Enumeration;
using Unity.VisualScripting;
using UnityEngine;

public class Items : MyMasterEntity
{
    internal float critChance = 0;
    internal float maxHpBonus = 0;


    // Start is called before the first frame update
    internal override void Start()
    {
        speedMult = 0;
        attackSpeedMult = 0;
        damageMult = 0;
        hpMult = 0;
    }

    // Update is called once per frame
    internal override void FixedUpdate()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            var player = other.gameObject.GetComponent<PlayerController>();
            player.baseHp += maxHpBonus;
            player.hpMult += hpMult;
            player.attackSpeedMult += attackSpeedMult;
            player.speedMult += speedMult;
            Destroy(gameObject);
        }
    }

}
