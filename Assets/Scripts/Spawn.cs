using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
public  GameObject food,protoz,protoz1;
public Vector2 vector;
public int n,m,k=1;
private void Awake() { n=Random.Range(20,25); 
m=Random.Range(15,20); 
    for(int i=0;i<n;i++){ 
   
    
    vector.Set(Random.Range(-8.5f,8.5f),Random.Range(-2.5f,4.5f));
    Instantiate(food,vector,Quaternion.identity);
    }
     for(int i=0;i<m;i++){
    vector.Set(Random.Range(-8.5f,8.5f),Random.Range(-2.5f,4.5f));
    Instantiate(protoz,vector,Quaternion.identity);
    vector.Set(Random.Range(-8.5f,8.5f),Random.Range(-2.5f,4.5f));
    Instantiate(protoz1,vector,Quaternion.identity);
    }
   
}
    
  
private float timeLeft=6;

    void Update()
    {
       timeLeft -= Time.deltaTime;
    if ( timeLeft < 0 ){
    n=Random.Range(10,15);  
    for(int i=0;i<n;i++){
    vector.Set(Random.Range(-8f,8f),Random.Range(-2.5f,4.5f));
    Instantiate(food,vector,Quaternion.identity);
    timeLeft=6;
    }
   
    }
    
    }
}
