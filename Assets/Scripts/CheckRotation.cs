using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckRotation : MonoBehaviour
{

    public int YRotation;

    public Text degrees;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.localEulerAngles = new Vector3(0, YRotation, 0);

        //transform.eulerAngles = new Vector3(transform.eulerAngles.x, YRotation, transform.eulerAngles.z);

        YRotation = (int)transform.localEulerAngles.y;

        degrees.text = YRotation.ToString(YRotation + "°");
    }
}

