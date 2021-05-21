using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFollow : MonoBehaviour
{

    public Transform[] players;
    public  bool followplayer;
    public Transform followthis;
   
    // Start is called before the first frame update
    void Start()
    {
       
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (followplayer)
        {
           
            foreach (Transform pl in players)
            {
                if (Vector3.Distance(this.transform.position, pl.position) < 12f)
                {
                    pl.transform.parent = followthis;
                   
                }
            }
           
          
        }
    }
}
