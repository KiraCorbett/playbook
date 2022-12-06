using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    // update to circle coordinates along x, y, z
    // map to mesh
    // fake rotation; 
    public float speed = 30.0f;

    bool rotate = false;

    public Transform parent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion currentRotation = transform.rotation;

        if(Input.GetKey(KeyCode.U))
        {
            rotate = !rotate;
        }
       
        //if (Input.GetKey(KeyCode.X))
        {
            //currentRotation = Quaternion.AngleAxis(Time.deltaTime * speed, transform.right) * currentRotation;
            transform.Rotate(Vector3.right, speed * Time.deltaTime);
            Debug.Log("Hit");
        }
                
        if (Input.GetKey(KeyCode.Y))
        {
            currentRotation = Quaternion.AngleAxis(Time.deltaTime * speed, transform.up) * currentRotation;
        }
            
        if (Input.GetKey(KeyCode.Z))
        {
            currentRotation = Quaternion.AngleAxis(Time.deltaTime * speed, transform.forward) * currentRotation;
        }


        //transform.rotation = currentRotation;
    }
}
