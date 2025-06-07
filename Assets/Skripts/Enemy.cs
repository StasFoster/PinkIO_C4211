using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform point;
    public Rigidbody body;
    public float speed = 1.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        body.AddForce(transform.forward * speed);
        transform.LookAt(point);
    }
}
