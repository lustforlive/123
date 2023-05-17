using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Food : MonoBehaviour
{
public float Grow;
public Vector2 vector;
public  GameObject food,proto;
public Transform protoz,protoz1;
public Text text,text1,text3;
private int s,c,fl=0;
private double k=0.5,m=0;
private void OnTriggerEnter2D(Collider2D collision) {
     if(collision.gameObject.tag=="food"){
     //transform.localScale+=new Vector3(Grow,Grow,Grow);
     s++;
     Destroy(collision.gameObject);
     }
}
private float timeLeft=10;
void Update()
{
    timeLeft -= Time.deltaTime;
    if ( timeLeft < 0 )
    { 
    if(fl==4 && s>=3)
    { 
    for(int i=0;i<2;i++){
    vector.Set(Random.Range(-8f,8f),Random.Range(-2.5f,2.5f));
    protoz.localScale=new Vector3(1,1,1);
    m=1;
    Instantiate(protoz,vector,Quaternion.identity);
    }
    }else {if(gameObject.tag=="ameba"&&fl==4){
    Destroy(gameObject);
    } }
    if(m>=1){
m+=0.5;
text3.text=m.ToString();
    }
    fl+=1;
        text.text=fl.ToString(); 
        k+=0.5;
   text1.text=k.ToString();
    if(s>=1 ){
   protoz.localScale+=new Vector3(Grow,Grow,Grow);
   //protoz1.localScale+=new Vector3(Grow,Grow,Grow);
        s=0;
       timeLeft=10; 
    }
    else{
    if(gameObject.tag=="ameba")
    {
     Destroy(gameObject);
    vector.Set(Random.Range(-9f,9f),Random.Range(-4.5f,4.5f));
    Instantiate(food,vector,Quaternion.identity);
     }
      
    }
    
       timeLeft=10;
    }
    
}
    // Start is called before the first frame update
  
}
