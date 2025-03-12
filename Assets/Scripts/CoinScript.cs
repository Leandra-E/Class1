using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
 public GameObject CoinPrefab;  
    //The player calls this function on the coin whenever they bump into it,
    //You can change its contents if you want something different to happen on collection
    //For example, what if the coin teleported to a new location instead of being destroyed?
  
    public void GetBumped()
    {
        //This destroys the coin
        //Destroy(gameObject);
    //    Vector3 pos = new Vector3(0, 0, 0);
    //    pos.x = Random.Range(-10f, 15f);
    //    transform.position = pos;
    
    Vector3 spawnPos1 = new Vector3(Random.Range(-10f,15f), Random.Range(-5f,5f), transform.position.z);
    Vector3 spawnPos2 = new Vector3(Random.Range(-10f,15f), Random.Range(-5f,5f), transform.position.z);
    
    Instantiate(CoinPrefab, spawnPos1, Quaternion.identity);
    Instantiate(CoinPrefab, spawnPos2, Quaternion.identity);
    
    Destroy(gameObject);
    
    }

}
