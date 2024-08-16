using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{

    //public float speed = 10;
    int shootTouchCount = 1;
    int moveTouchCount = 0;    
 

    public Vector3 MovementInput() {

        Vector3 posChange = Vector3.zero;
        if (Input.touchCount > moveTouchCount) {
            posChange += new Vector3(-Input.GetTouch(moveTouchCount).deltaPosition.y,0, Input.GetTouch(moveTouchCount).deltaPosition.x);
            
            return posChange;
        }
        return Vector3.zero;
    }

    public bool ShootingInput()
    {
        if (Input.touchCount > shootTouchCount)
        {
            if (Input.GetTouch(shootTouchCount).phase == UnityEngine.TouchPhase.Began)
            {
                return true;
            }
            else if(Input.GetTouch(shootTouchCount).phase == UnityEngine.TouchPhase.Moved)
            {
                return true;
            }
            else if (Input.GetTouch(shootTouchCount).phase == UnityEngine.TouchPhase.Stationary)
            {
                return true;
            }
            else if (Input.GetTouch(shootTouchCount).phase == UnityEngine.TouchPhase.Ended)
            {
                return false;
            }
        }
        return false;
    }
}
