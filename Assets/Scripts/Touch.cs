using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
public int count;
    // Start is called before the first frame update
    void Start()
    {
      count=0;  
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.touchCount>0){
      count++; 
Debug.Log(count);   
      }  
    }
}
