using UnityEngine;

public class HazardScript : MonoBehaviour
{
    public float Speed = 1;
    
    public Rigidbody2D hB;

    public GameObject Player;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
  
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, 
            Player.transform.position, Speed * Time.deltaTime);
        }
    }
    
   

