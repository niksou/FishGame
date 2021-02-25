using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PearlScript : MonoBehaviour
{
    GameObject pearl1;
    GameObject pearl;
    GameObject shell;
    public bool pearlTouch = false;

    // Start is called before the first frame update
    void Start()
    {
        pearl = GameObject.Find("pearl");
        pearl1 = GameObject.Find("pearl1");
        shell = GameObject.Find("shell");
        shell.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (pearlTouch == true)
        {
            shell.SetActive(true);
            pearl1.SetActive(false);
            pearl.SetActive(false);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "pearl1")
        {
            pearlTouch = true;
        }
    }
}
