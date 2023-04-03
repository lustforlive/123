 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
public  GameObject food,protoz;
public Vector2 vector;
public int n,m;

private void Start() {
  
}
public void ButClik(){
  m=Random.Range(15,20); 
  for(int i=0;i<m;i++){
    vector.Set(Random.Range(-9f,9f),Random.Range(-4.5f,4.5f));
    Instantiate(protoz,vector,Quaternion.identity);
    }
}
   
}
