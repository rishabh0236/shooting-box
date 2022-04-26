using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicmover : MonoBehaviour
{
    public float spin_speed= 100.0f;
    public float movementmag=0.1f;
    public bool dospin=true;
    public bool domovement=true;
    // Update is called once per frame
    void Update()
    {  if(dospin)
        {// for rotation of the gameobject on y axis
            gameObject.transform.Rotate(Vector3.up*spin_speed*Time.deltaTime);
        }
        if(domovement)
        {
            //for move ment of the object
            gameObject.transform.Translate(Vector3.up*Mathf.Cos (Time.timeSinceLevelLoad)*movementmag);
        }
    }
}
