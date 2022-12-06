using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// WIP: Rotation works to establish precision when rotation objects are using Quaternions.
// However, I was having difficulties with the x and y axes on a keyboard. This is because I am rotating along
// an axes. While the game is in Play Mode, you can watch the object's rotational values in the Scene View.

// Current function is just along the y-axis for a basic visual rotation.
// I chose working towards Quaternions because of the precision and to avoid a Gimbal Lock in Unity with Euler Angles.

// TODO: Create rotation gimbal gizomo via Blender for x, y, z rotational arrows.
public class Rotation : MonoBehaviour
{
    // update to circle coordinates along x, y, z
    // map to mesh
    // fake rotation; 
    public float speed = 30.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion currentRotation = transform.rotation;

       
        //if (Input.GetKey(KeyCode.X))
        //{
            //currentRotation = Quaternion.AngleAxis(Time.deltaTime * speed, transform.right) * currentRotation;
        //}
                
        if (Input.GetKey(KeyCode.Y))
        {
            currentRotation = Quaternion.AngleAxis(Time.deltaTime * speed, transform.up) * currentRotation;
        }
            
        //if (Input.GetKey(KeyCode.Z))
        //{
        //    currentRotation = Quaternion.AngleAxis(Time.deltaTime * speed, transform.forward) * currentRotation;
        //}


        transform.rotation = currentRotation;
    }
}
