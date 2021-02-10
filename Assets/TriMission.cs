using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriMission : MonoBehaviour
{
   public Rigidbody2D rb;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("TriDestenation"))
        {
            Debug.Log("dskdkads");
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
