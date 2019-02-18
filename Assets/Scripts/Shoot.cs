using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject bulletPosOrigin;

    // Start is called before the first frame update
    void Start()
    {
        
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bulletobj = Instantiate(bullet, bulletPosOrigin.transform.position, transform.rotation);
            bulletobj.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, 20));
            Destroy(bulletobj, 5);
        }
        
    }

     
}
