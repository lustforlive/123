 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
public int count;
private void Start() {
    count = 0;
}
public void ButClik(){
count++; 
Debug.Log(count);   
}
   
}
