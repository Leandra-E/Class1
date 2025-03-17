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
    public static int totalCoins = 1;
    public AudioClip coinSound;
    public int maxCoins = 15;
    public int spawnLimit = 2;
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        if (audioSource == null)
        {
            Debug.LogError("AudioSource not found on Coin object!");
        }
        else
        {
            Debug.Log("AudioSource found successfully!");
        }

        if (coinSound == null)
        {
            Debug.LogError("coinSound AudioClip is missing!");
        }

        Debug.Log("Playing coin sound...");
        AudioSource.PlayClipAtPoint(coinSound, transform.position);
        
    }
  
    public void GetBumped()
    {

        Destroy(gameObject, coinSound.length);
        if (audioSource != null && coinSound != null)
        {
            AudioSource.PlayClipAtPoint(coinSound, transform.position);
        }

        if (totalCoins >= maxCoins)
        {
            Destroy(gameObject);
            return;
        }
       // Vector3 spawnPos1 = new Vector3(Random.Range(-10f,10f), Random.Range(-5f,5f), transform.position.z);
      //  Vector3 spawnPos2 = new Vector3(Random.Range(-10f,14f), Random.Range(-5f,5f), transform.position.z);
    
    //  Instantiate(CoinPrefab, spawnPos1, Quaternion.identity);
    //  Instantiate(CoinPrefab, spawnPos2, Quaternion.identity);
    int coinsToSpawn = Mathf.Min(spawnLimit, maxCoins - totalCoins);
    for (int i = 0; i < coinsToSpawn; i++)
    {
        Vector3 spawnPos = new Vector3(Random.Range(-9f, 9f), Random.Range(-5f, 5f), transform.position.z);
        Instantiate(CoinPrefab, spawnPos, Quaternion.identity);
        totalCoins++;
    }
    Destroy(gameObject);
    
    }

}
