using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
public  GameObject food,protoz;
public Vector2 vector;
public int n,m;
private void Awake() { n=Random.Range(20,25); 
m=Random.Range(15,20); 
    for(int i=0;i<n;i++){
    vector.Set(Random.Range(-9f,9f),Random.Range(-4.5f,4.5f));
    Instantiate(food,vector,Quaternion.identity);
    }
     for(int i=0;i<m;i++){
    vector.Set(Random.Range(-9f,9f),Random.Range(-4.5f,4.5f));
    Instantiate(protoz,vector,Quaternion.identity);
    }
}
    
  
private float timeLeft=6;
    // Update is called once per frame
    void Update()
    {
       timeLeft -= Time.deltaTime;
    if ( timeLeft < 0 ){
    n=Random.Range(10,15);  
    for(int i=0;i<n;i++){
    vector.Set(Random.Range(-9f,9f),Random.Range(-4.5f,4.5f));
    Instantiate(food,vector,Quaternion.identity);
    timeLeft=6;
    }
   
    }
    
    }
}
