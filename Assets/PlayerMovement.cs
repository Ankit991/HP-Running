using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    public int movespeed,turnspeed;
    StartFollow startfollow;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startfollow = GetComponent<StartFollow>();
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 playerpos = transform.position;
        playerpos.x = Mathf.Clamp(transform.position.x, -6, 6);
        transform.position = playerpos;


        transform.Translate(Vector3.forward * movespeed*Time.deltaTime);
        float x = Input.GetAxis("Horizontal");


        transform.Translate(Vector3.right * x * turnspeed*Time.deltaTime);

       
        
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Follow")
        {
            startfollow.followplayer = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Follow")
        {
            startfollow.followplayer = false;
        }
    }

}
