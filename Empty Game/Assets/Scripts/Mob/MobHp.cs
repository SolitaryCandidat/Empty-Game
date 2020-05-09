using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobHp : MyHp
{
    public float originalHP = 100;
    private float currentHP;
    private Transform _transform;
    void Start()
    {
        _transform = GetComponent<Transform>();
        currentHP = originalHP;
    }
    public override bool SetDamage(float damage)
    {
        currentHP -= damage;
        if (currentHP > 0)
        {
            return true; //вовзращает true если персонаж не умер
        }
        else 
        {
            _transform.localScale = new Vector3(0.5f, 0.5f, 0.5f); //уменьшаем в 2 раза при смерти\
            Destroy(gameObject, 5); //уничтожить через 5 секунд 
            return false;
        }
    }

}
