using UnityEngine;

public class Test : MonoBehaviour
{
    int s = 0;
    Test d;
    BoxCollider gh;
    public Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 dir = new Vector3(12, 5, 0);
        rb.linearVelocity = dir;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
