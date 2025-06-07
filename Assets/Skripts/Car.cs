using UnityEngine;

public class Car : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 1;
    public float angleSpeed = 1;
    bool isGraund = true;
    void Update()
    {
         Ray under = new Ray(transform.position + new Vector3(0,0.6f,0) , -transform.up);
        RaycastHit hit = new RaycastHit();
        if (Physics.Raycast(under, out hit))
        { 
            
            if (hit.distance > 1)
            {
                isGraund = false;
            }
            else 
            {
                isGraund = true;
            }
            Debug.Log(hit.distance);
        }

        Debug.Log(isGraund);
        if (isGraund)
        {
            if (Input.GetKey(KeyCode.W))
            {
                rb.AddForce(transform.forward * speed);
                transform.Rotate(0, Input.GetAxis("Horizontal") * angleSpeed, 0);

            }
            if (Input.GetKey(KeyCode.S))
            {
                rb.AddForce(transform.forward * -speed);
                transform.Rotate(0, Input.GetAxis("Horizontal") * angleSpeed, 0);
            }
        }
    }
        
    }
  
       
