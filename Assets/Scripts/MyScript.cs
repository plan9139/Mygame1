using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript:MonoBehaviour
{
    int n = 0;

    void Start()
    {
        
		for (int n = 1; n <= 100; n++)	
       {
         print(n);
       }

    for (int n=1; n <= 100; n++) 
      {
      if(n%2==0)
        {
          print(n);
        }
    
      } 
      float x = 1.0f;
      float r = circle(x);

    float circle(float r)
      {
        float result;
        r = 2.0f;
        result = 3.14f * (r*r);
        print (result);
        return result;
      } 

    }  
    
}

