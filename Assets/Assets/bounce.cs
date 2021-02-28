using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce : MonoBehaviour
{


    
    public Rigidbody2D rb;
    public bool isFloor = false;
    public bool isRoof = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isFloor == true)
        {
            rb.gravityScale *= -1;
            isFloor = false;


        }
        if (isRoof == true)
        {
            
            rb.gravityScale *= -1;
            isRoof = false;
        }
       

    }


    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "floor")
        {
            isFloor = true;
        }
        if (col.gameObject.tag == "roof")
        {
            isRoof= true;
        }



    }



}
