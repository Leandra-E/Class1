using UnityEngine;

public class BackgroundScript : MonoBehaviour
{
    private AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
