using UnityEngine;

// It demonstrates Unity lifecycle methods.
public class CubertLifecycle : MonoBehaviour
{
    private float countdown;

    void Awake()
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV();
        Debug.Log("Cubert (Awake): Initialized internal color.");
    }

    void OnEnable()
    {
        countdown = 3f;
        Debug.Log("Cubert (OnEnable): Timer reset to 3 seconds.");
    }

    void Start()
    {
        if (Camera.main != null)
        {
            transform.LookAt(Camera.main.transform);
            Debug.Log("Cubert (Start): Oriented to face the main camera.");
        }
    }

    void Update()
    {
        transform.Rotate(Vector3.up * 30f * Time.deltaTime);
        countdown -= Time.deltaTime;
        if (countdown <= 0f)
        {
            Debug.Log("Cubert (Update): Countdown complete.");
        }
    }

    void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.forward * 5f);
    }

    void LateUpdate()
    {
        Vector3 pos = transform.position;
        pos.y = 0.5f;
        transform.position = pos;
    }

    void OnDisable()
    {
        Debug.Log("Cubert (OnDisable): Going inactive.");
    }

    void OnDestroy()
    {
        Debug.Log("Cubert (OnDestroy): Farewell, world.");
    }
}