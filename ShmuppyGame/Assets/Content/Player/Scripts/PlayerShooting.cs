using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    PlayerControls controls;

    private float rateOfFire;
    private float shootTime;
    private AudioSource source;


    public GameObject projectileTest;
    public Transform barrelTest;
    public AudioClip shotClip;
    

    private void Awake()
    {
        controls = GetComponent<PlayerControls>();
        source = GetComponent<AudioSource>();
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
        source.PlayOneShot(shotClip);
        shootTime = 0;
    }

    void GetRateOfFire()
    {
        rateOfFire = 0.25f;
        shootTime = rateOfFire;
    }
        
}
