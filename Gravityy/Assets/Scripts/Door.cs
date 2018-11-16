using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//extra using statement, for scene management functions
using UnityEngine.SceneManagement;
public class Door : MonoBehaviour {

    //Designer variables
    public string sceneToLoad;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //check if thing we collided with is player (aka has player script)
        Player playerScript = collision.collider.GetComponent<Player>();

        //only do this if thing ran into is player
        if (playerScript != null)
        {
            //we did hit player!
            //Load next level
            SceneManager.LoadScene(sceneToLoad);

        }
    }
}
