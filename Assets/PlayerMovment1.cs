using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovment1 : MonoBehaviour

{

    //public string levelToLoad;



    [SerializeField] private float speed = 950.0f;

    private Rigidbody2D rigidBody;
    static int counter = 0;
    
    GameObject digit;
    GameObject digit1;
    GameObject digit2;

    


    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        digit = GameObject.Find("digit5");
        digit.SetActive(false);
        digit1 = GameObject.Find("digit3");
        digit1.SetActive(false);
        digit2 = GameObject.Find("digit1");
        digit2.SetActive(false);



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
     

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "code")
        {
            if (counter == 0)
            {
                digit.SetActive(true);
                counter++;
            }
            else if (counter == 1)
            {
                digit1.SetActive(true);
                counter++;
            }
            else if (counter == 2)
            {
                digit2.SetActive(true);
                counter++;
            }
            else
            {
                Destroy(col.gameObject);
            }
        }
       
       

    }


}