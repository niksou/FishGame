using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovment : MonoBehaviour
{
    [SerializeField] private float speed = 950.0f;

    private Rigidbody2D rigidBody;
    static int counter = 0;
    GameObject babystar;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        babystar = GameObject.Find("Starfishbaby");
        babystar.SetActive(false);

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