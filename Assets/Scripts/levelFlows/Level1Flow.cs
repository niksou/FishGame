using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Flow : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    static int counter = 0;
    GameObject babystar;
    GameObject winLevel1;
    GameObject star1;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();

        babystar = GameObject.Find("Starfishbaby");
        babystar.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "bubble")
        {
            Destroy(col.gameObject);
            counter++;
        }
        if (counter == 4)
        {
            babystar.SetActive(true);
        }


    }


}
