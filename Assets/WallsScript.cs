using UnityEngine;

public class WallsScript : MonoBehaviour
{
    public float interval = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("MoveObjectRandomly", 0f, interval);
        
    }

    // Update is called once per frame
    void MoveObjectRandomly()
    {
     float randomX = Random.Range(-10f, 10f);
     Vector3 newPosition = new Vector3(randomX, transform.position.y,
         transform.position.z);
     transform.position = newPosition;
    }
}
