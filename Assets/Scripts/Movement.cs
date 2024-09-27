using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float x;
    float y; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis('Mouse X');
        y = Input.GetAxis('Mouse Y');
        Vector3 rotationVector = new Vector3(x, y, 0);
        Quaternion rotation = Quaternion.Euler(rotationVector);
    }

}
