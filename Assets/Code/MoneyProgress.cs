using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyProgress : MonoBehaviour
{
    public Slider slider;

    public void SetMaxMoney(int maxDough)
    {
        slider.maxValue = maxDough;
    }

    public void SetMoney(int money)
    {
        slider.value = money;
    }
}
