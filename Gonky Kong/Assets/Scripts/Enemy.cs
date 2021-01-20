using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float rotationSpeed = 180f;

    protected GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public virtual void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        Quaternion newRotation = Quaternion.identity;
        if (player != null) newRotation = Quaternion.LookRotation(transform.position - player.transform.position, Vector3.forward);
        newRotation.x = 0f;
        newRotation.y = 0f;

        //transform.rotation = newRotation;  //**no slurp
        transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, Time.deltaTime * 4);


    }
}
