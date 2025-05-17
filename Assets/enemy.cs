using UnityEngine;

public class enemy : MonoBehaviour
{
    public Transform player;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<bullet>() != null) { 
            gameObject.SetActive(false);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position,
            player.position, 0.01f);
    }
}
