 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
public  GameObject food,protoz,protoz1,protoz2;

    public GameObject[] protozoli;
public Vector2 vector;
public int n,m,count;
void Start()
    {
      count=0;  
    }
public void ButClik()
{
 m=Random.Range(15,20); 
  for(int i=0;i<m;i++){
  
    vector.Set(Random.Range(-8f,8f),Random.Range(-2.5f,2.5f));
    Instantiate(protoz,vector,Quaternion.identity);transform.localScale=new Vector3(0.5f,0.5f,0.5f);
    }
     n=Random.Range(30,40); 
  for(int i=0;i<n;i++){
    vector.Set(Random.Range(-9f,9f),Random.Range(-3f,4.5f));
    Instantiate(food,vector,Quaternion.identity);
    }
}
public void ButClik2()
{
 m=Random.Range(15,20); 
  for(int i=0;i<m;i++){
    vector.Set(Random.Range(-8f,8f),Random.Range(-2.5f,2.5f));
    Instantiate(protoz1,vector,Quaternion.identity);transform.localScale=new Vector3(0.5f,0.5f,0.5f);
    }
     n=Random.Range(30,40); 
  for(int i=0;i<n;i++){
    vector.Set(Random.Range(-9f,9f),Random.Range(-3f,4.5f));
    Instantiate(food,vector,Quaternion.identity);
    }
}
public void ButClik3()
{
 m=Random.Range(15,20); 
 
     n=Random.Range(30,40); 
  for(int i=0;i<n;i++){
    vector.Set(Random.Range(-9f,9f),Random.Range(-3f,4.5f));
    Instantiate(food,vector,Quaternion.identity);
    }
}
public void ButClik4()
{
foreach ( GameObject protoz in protozoli) 
        { 
           Destroy(gameObject);
        }


}
public void ButClik5()
{
 m=Random.Range(15,20); 
  for(int i=0;i<m;i++){
    vector.Set(Random.Range(-8f,8f),Random.Range(-2.5f,2.5f));
    Instantiate(protoz2,vector,Quaternion.identity);transform.localScale=new Vector3(0.5f,0.5f,0.5f);
    }
     n=Random.Range(30,40); 
  for(int i=0;i<n;i++){
    vector.Set(Random.Range(-8f,8f),Random.Range(-2.5f,4f));
    Instantiate(food,vector,Quaternion.identity);
    }
}
public void Speed()
{

}

/*public void Clik()
{
for(int i=0;i<n;i++){
    vector.Set(Random.Range(-8f,8f),Random.Range(-2.5f,4f));
    Instantiate(food,vector,Quaternion.identity);
    }
}
public void AAAA() {
      if(Input.touchCount>0){
      count++; 
Debug.Log(count);   
      }  
    }*/
}
   

