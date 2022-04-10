using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerActivate : MonoBehaviour
{
    // Private variables
    private float turnSpeed = 2500.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Turn the Propeller
        transform.Rotate(Vector3.back, Time.deltaTime * turnSpeed);
    }
}
