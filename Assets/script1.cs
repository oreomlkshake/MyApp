using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class script1 : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform
        target;
    public float
        height = 5f,
        distance = 10f,
        speed = 0.100f;

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3
                pos = target.position - target.forward * distance + Vector3.up * height,
                pos_fix = Vector3.Lerp(transform.position, pos, speed);

            transform.position = pos_fix;
            transform.LookAt(target.position);
        }    
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
