using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


// WIP: Manages buttons for transform actions
// If I were to continue this project, this class would manage various object manipulation.
// When one movement is enabled, the remainder movements would be disabled.
// Ex: If translation was clicked, only translation movements would be operatable.
public class Buttons : MonoBehaviour
{
    public UnityEvent unityEvent = new UnityEvent();
    public GameObject cubeButton;
    public GameObject materialCube;
    public SpawnManager spawnManager;
    public Button translateButton;

    // Start is called before the first frame update
    void Start()
    {
        cubeButton = gameObject;
        Button btn = translateButton.GetComponent<Button>();
        btn.onClick.AddListener(TranslateButton);   
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

    public void ScaleButton()
    {
        Debug.Log("Scale");
    }

    public void RotateButton()
    {
        Debug.Log("Rotate");
    }

    // 3D object as button
    public void SpawnButton()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("3D Button");
            spawnManager.Spawn();
        }

    }
}
