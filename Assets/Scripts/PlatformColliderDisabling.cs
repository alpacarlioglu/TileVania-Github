using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformColliderDisabling : MonoBehaviour
{
    CompositeCollider2D myCollider;
    PlayerMovement playerMovement;

    void Start()
    {
        myCollider = GetComponent<CompositeCollider2D>();
    }

    void Update()
    {   
        if (GameObject.Find("Player").GetComponent<PlayerMovement>().isAlive == false)
        {
            myCollider.isTrigger = true;
        }
    }
}
