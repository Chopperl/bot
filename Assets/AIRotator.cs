using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIRotator : MonoBehaviour
{

    public float spd = 0.1f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, spd, 0);   
    }
}
