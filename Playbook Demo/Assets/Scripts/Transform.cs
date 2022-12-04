using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform : MonoBehaviour
{
    public GameObject testCube;

    private Vector3 moveTransform;
    private Vector3 scaleTransform;

    private float speed = 5.0f;
    private float scale = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        testCube = GameObject.Find("TestCube");

        moveTransform = transform.localScale;
        scaleTransform = new Vector3(0.02f, 0.02f, 0.02f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector3.forward * speed * Time.deltaTime);
        }

        if(Input.GetMouseButton(0))
        {
            // transform.localScale = new Vector3(scale, scale, scale);
            testCube.transform.localScale = testCube.transform.localScale + scaleTransform;
        }
        if (Input.GetMouseButton(1))
        {
            testCube.transform.localScale = testCube.transform.localScale - scaleTransform;
        }
    }
}
