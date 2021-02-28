using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3Flow : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    GameObject chest;
    GameObject shell;
    GameObject key;
    [SerializeField] private float speed = 950.0f;

    public bool shellTouch = false;
    public bool keyTouch = false;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        chest = GameObject.Find("chest");
        chest.SetActive(false);
        shell = GameObject.Find("shell");

        key = GameObject.Find("key3");
        key.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (shellTouch == true)
        {

            key.SetActive(true);
            speed = 1500f;


        }
        if (keyTouch == true)
        {
            key.SetActive(false);
        }

    }

    private void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "shell")
        {
            shellTouch = true;

        }

        if (col.gameObject.tag == "key")
        {

            keyTouch = true;
            chest.SetActive(true);

        }

    }


}
