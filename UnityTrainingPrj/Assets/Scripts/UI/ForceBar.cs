using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForceBar : MonoBehaviour
{
    public Image fillBar;

    public void Reset()
    {
        fillBar.fillAmount = 0;
    }
    public void setFillAmount(float amount)
    {
        fillBar.fillAmount = amount;
    }
}
