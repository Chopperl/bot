using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AITrigger : MonoBehaviour
{

    public string direction;
    public float speedDir = 0;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        direction = "z";
        //Debug.Log("fff");
        //Debug.Log("*" + speedDir);

        AI_StandedTrigger standedTrigger = other.gameObject.GetComponent<AI_StandedTrigger>();
        bool[] stdDir = new bool[] { standedTrigger.left, standedTrigger.right, standedTrigger.front };



        if (stdDir[1])
        {
            speedDir = 1;
           // Debug.Log("**" + speedDir);
        }
        else
            if (stdDir[0])
            {
            speedDir = -1;
           // Debug.Log("***" + speedDir);
        }
            else {
            speedDir = 0;
           // Debug.Log("****" + speedDir);
        }

    }
}
