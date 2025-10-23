using UnityEngine;

public class OrbKontrol : MonoBehaviour
{

    Rigidbody rb;




    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            rb.useGravity = true;
        }
    }
}
