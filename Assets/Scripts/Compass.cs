using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Compass : MonoBehaviour
{

    public RawImage compassImage;
    public Transform player;



    

    // Update is called once per frame
    public void Update()
    {
        compassImage.uvRect = new Rect(player.localEulerAngles.y / 360, 0f, 1f, 1f);

    }

}
