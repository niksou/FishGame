using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovment2 : MonoBehaviour

{

    //public string levelToLoad;



    [SerializeField] private float speed = 950.0f;

    private Rigidbody2D rigidBody;
    GameObject chest;
    GameObject shell;
    GameObject key;

    public bool shellTouch = false;
    public bool keyTouch = false;
    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        chest = GameObject.Find("chest");
        chest.SetActive(false);
        shell = GameObject.Find("shell");
        
        key = GameObject.Find("key3");
        key.SetActive(false);
    }


    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float deltaY = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        Vector2 movement = new Vector2(deltaX, deltaY);
        rigidBody.velocity = movement;

        if (!Mathf.Approximately(deltaX, 0.0f))
        {
            // Scale x to either positive or negative 1 to 'turn' the character
            transform.localScale = new Vector3(Mathf.Sign(deltaX), 1.0f, 1.0f);
        }

        if (shellTouch == true)
        {
            
            key.SetActive(true);
            speed = 1500f;

            
        }
        if(keyTouch == true)
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

        if(col.gameObject.tag == "key")
        {

            keyTouch = true;
            chest.SetActive(true);
           
        }
        



    }


}