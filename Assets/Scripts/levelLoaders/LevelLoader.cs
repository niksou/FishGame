using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class LevelLoader : MonoBehaviour
{

    private bool playerInZone;

    public string levelToLoad;
    // Start is called before the first frame update
    void Start()
    {
        playerInZone = false;

        
    }

    // Update is called once per frame
    void Update()
    {
        if( playerInZone)
        {
            Application.LoadLevel(levelToLoad);
        }
    }

  



    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Application.LoadLevel(levelToLoad);
        }
     

    }
}
