using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHeal : MonoBehaviour
{  
    public int collisionHeal = 10;
    public string collisionTag;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == collisionTag)
        {
            Health health = other.gameObject.GetComponent<Health>();
            health.SetHealth(collisionHeal);
            Destroy(gameObject);
        }
    }
}
