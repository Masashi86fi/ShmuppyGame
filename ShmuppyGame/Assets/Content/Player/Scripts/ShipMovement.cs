using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ShipMovement : MonoBehaviour
{
    Rigidbody myRig;
    PlayerControls controls;

    private void Awake()
    {
        myRig = GetComponent<Rigidbody>();
        controls = GetComponent<PlayerControls>();
    } 

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        myRig.position += controls.MovementInput()*10*Time.fixedDeltaTime;
        myRig.position = new Vector3(Mathf.Clamp(myRig.position.x,GameArea.minX,GameArea.maxX),0, Mathf.Clamp(myRig.position.z, GameArea.minY, GameArea.maxY));
    }
}
