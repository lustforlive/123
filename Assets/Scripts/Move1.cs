using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move1 : MonoBehaviour
{public float speed;
public Vector2 vector;
private Transform target;
    void Awake()
{
    // Move our position a step closer to the target.
   var step =  speed * 0.01f; // calculate distance to move
    transform.position = Vector3.MoveTowards(transform.position, target.position,step);

    // Check if the position of the cube and sphere are approximately equal.
    if (Vector3.Distance(transform.position, target.position) < 0.001f)
    {
        // Swap the position of the cylinder.
        target.position *= -1.0f;
    }
    if (Vector3.Distance(transform.position, target.position) > 0.001f)
    {
        // Swap the position of the cylinder.
        target.position *= 1.0f;
    }
}
        
  

  /* public float c,a,x=0,y=0,z=0;
 void Start()
    {
        speed = Random.Range(2f, 7f);
    }
  public void FixedUpdate() {
 
  c = Random.Range(0f, 1f);
  a = Random.Range(0f, 1f);
  vector.x= Mathf.Acos(c);
  vector.y= Mathf.Asin(a);
  
    transform.Translate( vector.normalized*speed);
  
    if (transform.position.y> 4.5f)
        {
            speed = -speed;
            
 
        }
        if (transform.position.y< -4.5f)
        {
            speed  = Random.Range(0.01f, 0.1f);
           
 
         }   
    if (transform.position.x> 9.5f)
        {
            speed = -speed;
           
 
        }
        if (transform.position.x < -9.5f)
        {
           speed  = Random.Range(0.01f, 0.1f);
          

       }
       if (c<0.5f){
       vector.x= Mathf.Acos(c)-Mathf.Asin(c);
       vector.y=Mathf.Acos(c)+Mathf.Asin(c);
       }
       else{
       x= Mathf.Acos(a)-Mathf.Asin(a);
       y=Mathf.Acos(a)+Mathf.Asin(a);
       }
       if(transform.position.y< 4.5f && transform.position.x< 9.5f){
 transform.Translate(x,y,z);
}
  }*/

   
    }
  
