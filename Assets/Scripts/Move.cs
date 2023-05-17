using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Move : MonoBehaviour
{

   /* public float speed;
private Vector2 targetPos;

    void Update()
    {
    targetPos.x = Random.Range(-3.5f, 3.5f)*speed;
    targetPos.y = Random.Range(-3.5f, 3.5f)*speed;
       /*Vector3 Target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Target.z = transform.position.z;
        transform.position = Vector3.MoveTowards(transform.position, Target, speed * Time.deltaTime / transform.localScale.x);
        
        vector.normalized */
public float speed;
public Text text2;
public Vector2 vector;
   public float c,a,b,w,v;
   
 void Start()
    {
        speed = Random.Range(2f, 7f);
        
text2.text= speed.ToString();
    }
  public void FixedUpdate() {
 w = Random.Range(1,10);
 b=Random.Range(0, 10);
 a= Random.Range(0f,1f);
 c=Random.Range(0f,1f);
 v= Random.Range(0,10);
  //vector.x= Mathf.Acos(c);
  //vector.y= Mathf.Asin(a);
  vector.x=Mathf.PerlinNoise(a,transform.position.x);
vector.y=Mathf.PerlinNoise(c,transform.position.y);
if(w==1)
{
  vector.x= Mathf.Acos(c)-Mathf.Asin(c);
  vector.y= Mathf.Asin(a)+Mathf.Acos(a);}
  if(w==2)
  {
    vector.x=Mathf.Acos(-c)-Mathf.Asin(-c);
    vector.y= Mathf.Asin(-a)+Mathf.Acos(-a);}
    
    if(w==3)
    {
    vector.x= Mathf.Acos(c)-Mathf.Asin(c);
    vector.y=Mathf.Asin(-a)+Mathf.Acos(-a);
  }
   if(w==4)
    {
    vector.x=Mathf.Acos(-c)-Mathf.Asin(-c);
    vector.y= Mathf.Asin(a)+Mathf.Acos(a);
  }

 /* if(w==1)
{
  vector.x=-Mathf.PerlinNoise(a,transform.position.x);
vector.y=-Mathf.PerlinNoise(c,transform.position.y);}
  if(w==2)
  {
   vector.x=Mathf.PerlinNoise(a,transform.position.x);
vector.y=Mathf.PerlinNoise(c,transform.position.y);}
    
    if(w==3)
    {
   vector.x=Mathf.PerlinNoise(a,transform.position.x);
vector.y= -Mathf.PerlinNoise(c,transform.position.y);
  }
   if(w==4)
    {
   vector.x= -Mathf.PerlinNoise(a,transform.position.x);
vector.y=Mathf.PerlinNoise(c,transform.position.y);
  }*/


  transform.Translate( vector.normalized*speed);

    
   

    if (transform.position.y> 4.5f)
        {
            speed = -speed;
             
        }
        if (transform.position.y< -2.5f)
        {
            speed  = Random.Range(0f, 0.1f);
           
 
         }   
    if (transform.position.x> 8f)
        {
            speed = -speed;
          
        }
        if (transform.position.x < -8f)
        {speed  = Random.Range(0f, 0.1f);
           //speed  = Random.Range(0.01f, 0.1f);
             
       }


  }

   
    }

