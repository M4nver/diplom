using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   public float speed;
   private bool movingRight = true;


    private void Update()
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            if(movingRight == true) 
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
            } else 
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
            }
        }

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("2");
        if(other.gameObject.tag == "Block") 
        {
            if(movingRight) 
            {
                movingRight = false;
            }
            else
            {
                movingRight = true;
            }
        }  
        Debug.Log(movingRight);     
    }
}
