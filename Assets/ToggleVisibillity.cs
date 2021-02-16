using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleVisibillity : MonoBehaviour
{
     Renderer rend;
  

    void Start()
    {
         rend = gameObject.GetComponent<Renderer>();
         rend.enabled = false;
        

    }

    public void letVisible()
    {
     rend.enabled = true;
    }

  
}
