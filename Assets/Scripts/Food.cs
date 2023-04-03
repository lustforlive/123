using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
public float Grow;
//public  GameObject food,protoz;
//public GameObject food,protoz;
public Vector2 vector;
private int s,c;
private void OnTriggerEnter2D(Collider2D collision) {
     if(collision.gameObject.tag=="food"){
     //transform.localScale+=new Vector3(Grow,Grow,Grow);
     s++;
     Destroy(collision.gameObject);
     }
}
private float timeLeft=6;
void Update()
{
    timeLeft -= Time.deltaTime;
    if ( timeLeft < 0 )
    {
    if(s>=1)
    {
    transform.localScale+=new Vector3(Grow,Grow,Grow);
        //что-то сделать по окончанию времени
        s=0;
       timeLeft=6; 

    }
    else{
    if(gameObject.tag=="ameba")
    {
     Destroy(gameObject);
    // vector.Set(Random.Range(-9f,9f),Random.Range(-4.5f,4.5f));
    //Instantiate(food,vector,Quaternion.identity);
     }
    }
    
       timeLeft=6;
    }
    
}
    // Start is called before the first frame update
  
}
