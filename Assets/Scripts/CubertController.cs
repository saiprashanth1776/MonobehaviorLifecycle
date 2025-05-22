using UnityEngine;

// Handles creating, enabling/disabling, and destroying Cubert via keyboard.
public class CubertController : MonoBehaviour
{
    public GameObject cubertPrefab;
    private GameObject cubertInstance;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (cubertInstance == null)
            {
                cubertInstance = Instantiate(cubertPrefab, Vector3.zero, Quaternion.identity);
                cubertInstance.name = "Cubert";
                Debug.Log("Spawner: Cubert created.");
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (cubertInstance != null)
            {
                bool isActive = cubertInstance.activeSelf;
                cubertInstance.SetActive(!isActive);
                Debug.Log($"Spawner: Cubert is now {(isActive ? "disabled" : "enabled")}.");
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            if (cubertInstance != null)
            {
                Destroy(cubertInstance);
                Debug.Log("Spawner: Cubert destroyed.");
            }
        }
    }
}