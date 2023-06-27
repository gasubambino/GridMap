using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    public static int objSelected = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            objSelected = 1;
        }else if (Input.GetKeyDown(KeyCode.Alpha2)) { objSelected = 2;}else if (Input.GetKeyDown(KeyCode.Alpha3)) { objSelected = 3;}
        switch(objSelected)
        {
            case 1:
                 
                break;
            case 2:
                 
                break;
            case 3:
                 
                break;
        }
    }
}
