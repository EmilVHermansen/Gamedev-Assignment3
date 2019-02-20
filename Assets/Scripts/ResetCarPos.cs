using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCarPos : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            transform.Rotate(0f, 0f, 0f);
            //transform.Translate(0, 5, 0);
            //transform.rotation = new Quaternion(0, transform.rotation.y, transform.rotation.z, transform.rotation.w);
            transform.rotation = Quaternion.identity;
            //X rotation
        }
    }
}
