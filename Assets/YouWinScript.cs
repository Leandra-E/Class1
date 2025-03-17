using UnityEngine;
using UnityEngine.SceneManagement;

public class YouWinScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If the player hit space. . .
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Then load the 'Example 3' scene
            SceneManager.LoadScene("Example 3");
        }
    }
}
