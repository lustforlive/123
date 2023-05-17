using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move1 : MonoBehaviour

{ public float speed;
public float c,a,b;
public Vector3 vec;
Vector3 vector ;

Vector3 RandomSmoothPointOnUnitSphere(float time)
{
  c =Random.Range(0f,1f);
   a =Random.Range(0f,1f);
  //Get the x of the vector
  float x = Mathf.PerlinNoise(a,transform.position.x);
 // if(this.transform.position.x > 4.5f){


 //b = -1f;
 //x = Mathf.PerlinNoise(b,b);
//speed= -speed;
//float x = Mathf.PerlinNoise(-1,this.transform.position.x*speed);

 //transform.Translate(movementvector * Time.deltaTime*speed );
//}
  //Get the y of the vector
  float y = Mathf.PerlinNoise(c,transform.position.y);
  
  //Get the z of the vector
  float z = Mathf.PerlinNoise(time,0);
  
  //Create a vector3
  vector = new Vector3(x, y, z);
  speed = Random.Range(0f,0.1f);
  //Normalize the vector and return it
  return Vector3.Normalize(vector*speed);
  
}


private void Update(){
Vector3 movementvector = RandomSmoothPointOnUnitSphere(Time.time);
if(this.transform.position.x > 7f){
//speed= -speed; 
speed  = Random.Range(0f, 0.1f);
transform.Translate( vector.normalized*speed);

//float x = Mathf.PerlinNoise(-1,this.transform.position.x*speed);

 //transform.Translate(movementvector * Time.deltaTime*speed );
}
if(this.transform.position.y > 4.5f){
 b = Random.Range(0f,4.5f);
Vector3 vec = new Vector3(this.transform.position.x, 4.5f, this.transform.position.z);
this.transform.position=vec;
speed= -speed;
transform.Translate( vector.normalized*speed);
}
if(this.transform.position.x <-4.5f){
 b = Random.Range(0f,9.5f);
Vector3 vec = new Vector3(9.5f, this.transform.position.y, this.transform.position.z);
this.transform.position=vec;
speed=-speed;
 //speed  = Random.Range(0f, 0.1f);
 transform.Translate( vector.normalized*speed);
}

if(this.transform.position.y < -4.5){
 b = Random.Range(-4.5f,0f);
Vector3 vec = new Vector3(this.transform.position.x, 4.5f, this.transform.position.z);
this.transform.position=vec;
speed  = Random.Range(0f, 0.1f);
transform.Translate( vector.normalized*speed);
}
speed = Random.Range(0f,0.1f);
a = Random.Range(0f,0.1f);
c = Random.Range(0f,0.1f);
  
  //Get the vector
  
  
  //You can also use CharacterController.Move()
 
  
   if (transform.position.y > 4.5f)
    {
    speed= -speed;
    transform.Translate( vector.normalized*speed*Time.deltaTime);
    }
    if (transform.position.x> 9.5f)
    {
   speed = -speed;
   transform.Translate( vector.normalized*speed*Time.deltaTime);
    }
     if (transform.position.y< -4.5f)
        {
            speed  =-speed;
            transform.Translate( vector.normalized*speed*Time.deltaTime);
        }
         if (transform.position.x < -9.5f)
        {speed  = -speed;
        transform.Translate( vector.normalized*speed*Time.deltaTime);
        }
         transform.Translate(movementvector * Time.deltaTime*speed );
        }
        }
  
