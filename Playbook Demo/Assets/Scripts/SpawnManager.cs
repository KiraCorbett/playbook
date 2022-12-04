using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // create button
    // spawn gameobjects
    // get active gameobject onclick

    // add rigidbody
    // create new scripts on instantiation and attach
    // movement

    public GameObject gameObject;
    public int size;
    public UnityEngine.Transform parent;

    public GameObject getSpawnObjects()
    {
        return gameObject;
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Spawn()
    {
        Instantiate(gameObject, new Vector3(0, 25, 0), Quaternion.identity, parent);
    }
}
