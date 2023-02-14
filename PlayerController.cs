#if UNITY_ANDROID
#define USING_MOBILE
#endif
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder;

public class PlayerController : MonoBehaviour
{
    public float Rlimit,Llimit;
    private float speed = 18f, pointA, pointB;
    private bool touchStart;
    private float rightLimT = -350f, leftLimit = 85f;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
#if USING_MOBILE
        if(transform.position.x < Llimit)
        {
            transform.Translate(new Vector3 (Llimit-Rlimit+3f ,0,0));
        }
        else if (transform.position.x > Rlimit)
        {
            transform.Translate(new Vector3(Rlimit-Llimit-3f, 0, 0));
        }
        else this.transform.Translate((new Vector3(-directionOfMouse(), 0, 0) * speed * Time.deltaTime));
        
        #endif

        
    }
    int directionOfMouse()
    {
        if (Input.GetMouseButtonDown(0) &&  (Input.mousePosition.y < (Screen.height / 3)))
        {       
                pointA = Input.mousePosition.x;
                touchStart = true;
        }
        
        if (Input.GetMouseButtonUp(0)) {
            touchStart = false;
        }
        else if (touchStart)
        {
            pointB = Input.mousePosition.x;
            if ((pointB - pointA) >= 100) return 1;
            else if((pointB - pointA) <= -100)return -1;
        }
        return 0;
    }

}
   
