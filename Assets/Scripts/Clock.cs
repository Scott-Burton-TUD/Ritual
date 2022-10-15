using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{

    private Text clock;

    // Start is called before the first frame update
    void Start()
    {
        clock = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        System.DateTime time = System.DateTime.Now;

        clock.text = time.ToString("hh:mm");
    }
}
