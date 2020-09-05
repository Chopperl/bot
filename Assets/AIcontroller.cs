using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.UIElements;
using UnityEngine;
using UnityEngine.Rendering;

public class AIcontroller : MonoBehaviour
{
    public GameObject triggerO;
    public float speed = 10f;
    bool flag = false;
    int c = 0;


    AIRotator rot ;

    float posY;
    // Start is called before the first frame update
    void Start()
    {
        rot = GetComponent<AIRotator>();
        rot.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        AITrigger trigger_scr = triggerO.GetComponent<AITrigger>();
        string direction = trigger_scr.direction;
        drive(direction);

        transform.Translate(0, 0, speed * Time.deltaTime);


        if (trigger_scr.speedDir != 0)
        {
            float rotY = transform.rotation.eulerAngles.y - transform.rotation.eulerAngles.y % 10;
            rot.enabled = true;

            if (c == 1) { 
                rot.spd = rot.spd * trigger_scr.speedDir;
                c = 0;
            }

            if ((System.Math.Abs(rotY) ==  90 || System.Math.Abs(rotY) == 270) && !flag ) {
                c = 1;
                flag = true;
                rot.enabled = false;
                trigger_scr.speedDir = 0;
                Debug.Log(rot.enabled);
            }
            if ((System.Math.Abs(rotY) == 0 || System.Math.Abs(rotY) == 180) && flag )
            {
                c = 1;
                flag = false;
                rot.enabled = false;
                trigger_scr.speedDir = 0;
                Debug.Log(rot.enabled);
            }

        }
    }

    void drive( string dir)
    {
        
    }
}
