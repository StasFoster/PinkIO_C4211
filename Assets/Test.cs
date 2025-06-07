using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Test : MonoBehaviour
{
    int s = 0;
    string t;
    Test d;
    BoxCollider gh;
    public Rigidbody rb;
    public Transform pos;
    public GameObject bullet;
    public Transform point;
    float xRotation = 0f;

    private void OnCollisionEnter(Collision collision)
    {
        //rb.AddForce(new Vector3(0, 200, 0));
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        Vector3 dir = new Vector3(0, 100, 0);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void Update()
    {
        Transform r = Camera.main.transform;
        rb.linearVelocity = (pos.forward * Input.GetAxis("Vertical") 
            + pos.right * Input.GetAxis("Horizontal")) * 5
            + new Vector3(0,rb.linearVelocity.y,0);
        pos.Rotate(0, Input.GetAxis("Mouse X") * 2, 0);
        
        float mouseY = Input.GetAxis("Mouse Y") * 2;
      
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90); 

        r.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        if (Input.GetMouseButtonDown(0))
        {
              Rigidbody a = Instantiate(bullet,point.position,Quaternion.identity).GetComponent<Rigidbody>();
            Vector3 s = pos.forward * 5;
            a.AddForce(s);
        }
        

    }
}

