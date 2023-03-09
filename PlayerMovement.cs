using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // transform.position += new Vector2(x,y)
        // transform.translate(x,y)
        // Time.deltaTime is the amount of time since teh last frame
        // vector2.up
    }
    public float speed = 4;
    public float degree = 5;
    private bool isrotatingc = false;
    private bool isrotatingcc = false;
    // Update is called once per frame
    void Update()
    {   
        //float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        // bool x = Input.GetKey("w");
        // if(x == true) {
        //     Vector2 movement = new Vector2(0,1);
        //     transform.Translate(movement * speed * Time.deltaTime); 
        // }
        Vector2 movement = new Vector2(0,y);
        transform.Translate(movement * speed * Time.deltaTime);
        // else if(x != 0){
        //     Vector2 movement = new Vector2(x,0);
        //     transform.Translate(movement * speed * Time.deltaTime);
        // }
        //Vector2 movement = new Vector2(x,y);
        
        bool startclockw = false;
        startclockw = Input.GetKey("d");
        if(isrotatingc == false && startclockw == true)
        {
            Vector3 rot = new Vector3(0,0,1);
            transform.eulerAngles -= rot * degree * 0.0001f / Time.deltaTime;
            isrotatingc = true;
            //startclockw = false;
        }
        //startclockw = Input.GetKey("d");
        if(isrotatingc == true && startclockw == true)
        {
            isrotatingc = false;
        }
        
        bool startcclock = false;
        startcclock = Input.GetKey("a");
        if(isrotatingcc == false && startcclock == true)
        {
            Vector3 rot = new Vector3(0,0,1);
            transform.eulerAngles += rot * degree * 0.0001f / Time.deltaTime;
            isrotatingcc = true;
            //startcclock = false;
        }
        //startcclock = Input.GetKey("a");
        if(isrotatingcc == true && startcclock == true)
        {
            isrotatingcc = false;
        }
        //transform.Translate(movement * speed * Time.deltaTime); 
    }
}
