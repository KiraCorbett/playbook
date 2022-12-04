using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Buttons : MonoBehaviour
{
    public UnityEvent unityEvent = new UnityEvent();
    public GameObject cubeButton;
    public GameObject materialCube;
    public SpawnManager spawnManager;

    // Start is called before the first frame update
    void Start()
    {
        cubeButton = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
        {
            unityEvent.Invoke();
        }
    }

    // default button actions
    public void ButtonAction()
    {
        Debug.Log("Button");
    }

    public void TranslateButton()
    {
        Debug.Log("Translate");
    }

    // 3D object as button
    public void SpawnButton()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Button");
            spawnManager.Spawn();
        }

    }
}
