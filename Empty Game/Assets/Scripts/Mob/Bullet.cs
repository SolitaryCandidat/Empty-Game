using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float timeLife = 30; //время жизни
    private float timeDeath; 
    void Start()
    {
        timeDeath = Time.time + timeLife;
    }
    void FixedUpdate()
    {
        if(Time.time > timeDeath)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        MyBehaviour collisionBehaviour = collision.gameObject.GetComponent<MyBehaviour>(); //При ударе обо что-нибудь данный скрипт получает у этого чего-нибудь компонент MyBehaviour(или любой его наследник)
        if (collisionBehaviour)
        {
            collisionBehaviour.SetDamage(30);
        }
        Destroy(gameObject);
    }
}
