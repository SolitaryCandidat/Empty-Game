using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobBehaviour : MyBehaviour
{
    public MyHp thisHP;
    private bool isLive = true;
    
    void Start()
    {
        thisHP = GetComponent<MyHp>();
    }
    public override void SetDamage(float damage)
    {
        if(isLive)
        {
            if(thisHP.SetDamage(damage))
            {

            }
            else
            {
                Debug.Log("моб мертв");
            }
        }
    }
}
