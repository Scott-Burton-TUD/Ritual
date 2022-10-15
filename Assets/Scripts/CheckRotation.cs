using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckRotation : MonoBehaviour
{

    public float YRotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles = new Vector3(0, YRotation, 0);
    }
}
