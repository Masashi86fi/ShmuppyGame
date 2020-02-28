using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    PlayerControls controls;

    private float rateOfFire;
    private float shootTime;

    public GameObject projectileTest;
    public Transform barrelTest;


    private void Awake()
    {
        controls = GetComponent<PlayerControls>();
    }

    // Start is called before the first frame update
    void Start()
    {
        GetRateOfFire();
    }

    // Update is called once per frame
    void Update()
    {

        if (shootTime >= rateOfFire)
        {           
            if (controls.ShootingInput())
            {
                Shoot();                
            }
           
        }
        else
        {
            shootTime += Time.deltaTime;
        }

        
    }

    void Shoot()
    {
        GameObject shot = Instantiate(projectileTest, barrelTest.position,barrelTest.rotation);
        shot.GetComponent<Rigidbody>().AddForce(barrelTest.forward*100,ForceMode.Impulse);
        shootTime = 0;
    }

    void GetRateOfFire()
    {
        rateOfFire = 0.25f;
        shootTime = rateOfFire;
    }
        
}
