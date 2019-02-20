using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Shuffle : MonoBehaviour
{
    //public GameObject mySphere;
    //[HideInInspector] public float speed = 300;
    //float delayTimer = 2f;
    [SerializeField] int range;
    float posX;
    float posY;
    float posZ;
    //float targetX = 10f;
    //Vector3 startPosition;
    //Vector3 endPosition;
    //public float lerpValue;

    // Start is called before the first frame update
    void Start()
    {
        posX = transform.position.x;
        posY = transform.position.y;
        posZ = transform.position.z;

        //startPosition = transform.position;
        //endPosition = new Vector3(10, 1, 1);
        StartCoroutine(shuffleMovement());
    }

    // Update is called once per frame
    void Update()
    {
        posX = transform.position.x;
        posY = transform.position.y;
        posZ = transform.position.z;

    }

    IEnumerator shuffleMovement()
    {
        MoveDoTween(range);
        yield return new WaitForSeconds(8f);
        MoveDoTween(-range);
        yield return new WaitForSeconds(8f);
        StartCoroutine(shuffleMovement());
    }

    void MoveDoTween(int posXMovement)
    { 
        transform.DOMoveX(posX + posXMovement, 3f);
    }
}
