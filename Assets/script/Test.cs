using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    
    
    
    // Start is called before the first frame update
     void Start()
    {
        int[] array=new int[5];
        array[0]=2;
        array[1]=20;
        array[2]=23;
        array[3]=30;
        array[4]=33;

        for (int i=0;i<5;i++)
        {
            Debug.Log(array[i]);
        }
        
        

    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
