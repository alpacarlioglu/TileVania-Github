using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{   
    CompositeCollider2D myCompositCollider;
    void Start()
    {
        myCompositCollider = GetComponent<CompositeCollider2D>();
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (gameObject.tag == "Player")
        {
            // myCompositCollider.gravity = 2f;
        }    
    }
}
