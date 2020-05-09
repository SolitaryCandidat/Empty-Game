using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
    public GameObject BulletPref;
    public float BulletSpeed = 30;
    public float ShotPause = 1;

    private Transform _сameraTransform;
    private float TimeLastShot = 0;
   
    void Start()
    {
        _сameraTransform = transform.FindChild("Main Camera");
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.Mouse0))
        {
            if (Time.time > TimeLastShot + ShotPause)
            {
                GameObject newBullet = (GameObject)Instantiate(BulletPref, _сameraTransform.position + _сameraTransform.forward, Quaternion.identity);
                Rigidbody BulletRB = newBullet.GetComponent<Rigidbody>();
                BulletRB.AddForce(_сameraTransform.forward * BulletSpeed, ForceMode.VelocityChange);

                TimeLastShot = Time.time;
            }
        }
    }
}
