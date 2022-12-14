using UnityEngine;

// SpawnManager spawns cubes when a 3D cube button is clicked. 
public class SpawnManager : MonoBehaviour
{
    public GameObject gameObject;
    public UnityEngine.Transform parent;

    public GameObject getSpawnObjects()
    {
        return gameObject;
    }

    public void Spawn()
    {
        Instantiate(gameObject, new Vector3(-10, 8, 120), Quaternion.identity, parent);
    }
}
