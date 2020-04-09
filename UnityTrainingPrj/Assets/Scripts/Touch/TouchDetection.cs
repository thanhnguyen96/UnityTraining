using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TouchDetection : MonoBehaviour
{
    public Text touchTypeTxt;
    public Text touchInfoTxt;
    private Touch touch;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        string multiTouchInfo = "";
        if (Input.touchCount > 0)
        {
            for (int i = 0; i < Input.touchCount; i++)
            {
                touch = Input.GetTouch(i);

                multiTouchInfo += string.Format("Touch {0} -Position {1}-Tap Count: {2} -Finger ID: {3}\nRadius: {4} ({5}%)\n",
                i, touch.position, touch.tapCount, touch.fingerId, touch.radius,
                ((touch.radius / (touch.radius + touch.radiusVariance)) * 100f).ToString("F1"));
            }
            touchTypeTxt.text = Input.touchCount == 1 ? "Single Touch" : "Multi Touch";
        }
        else
        {
            touchTypeTxt.text = "No Touch";
        }
        touchInfoTxt.text = multiTouchInfo;
    }
}
