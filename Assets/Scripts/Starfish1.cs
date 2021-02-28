using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starfish1 : MonoBehaviour
{

    public bool touch = false;
    public bool touch1 = false;
    GameObject winLevel1;
    GameObject star1;
    GameObject star2;


    // Start is called before the first frame update
    void Start()
    {
        star1 = GameObject.Find("Starfish1");
        star2 = GameObject.Find("Starfish2");
        winLevel1 = GameObject.Find("levelEnd");
        winLevel1.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (touch && touch1)
        {
            winLevel1.SetActive(true);
        }
    }


    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "babystar")
        {
            touch = true;
        }
        if (col.gameObject.tag == "starfish")
        {
            touch1 = true;
        }
       


    }

}
