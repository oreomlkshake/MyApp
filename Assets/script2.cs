using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script2 : MonoBehaviour
{
    // Start is called before the first frame update

    public float
        speedMove = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float
            horInput = Input.GetAxis("Horizontal"),
            verInput = Input.GetAxis("Vertical");

        Vector3
            direction = new Vector3(horInput, 0.0f, verInput);

        transform.Translate(direction * speedMove * Time.deltaTime);
    }
}
