using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{

    private Slider slider;

    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
    }
    public bool isFull()
    {
        return slider.value == 1;
    }
    // Update is called once per frame
    void Update()
    {
        slider.value = DataManager.Instance.distance / DataManager.Instance.maxDist;
    }
}
