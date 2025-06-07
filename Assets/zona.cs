using UnityEngine;

public class zona : MonoBehaviour
{
    public float force = 30;
    private void OnTriggerStay(Collider other)
    {
        other.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, force, 0), ForceMode.Force);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
