using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    // Start is called before the first frame update
    public float fillSpeed = 0.5f;
    public float targetProgess = 0;
    private Slider slider;

    

    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>(); 
    }
    void Start()
    {
        fillOverTime(10);
    }
    void fillOverTime(float timeUntilFinished)
    {
        fillSpeed = 1/timeUntilFinished;
        targetProgess = 0;
        incrementProgress(1);
}

    // Update is called once per frame
    void Update()
    {
            if (slider.value < targetProgess)
        {
            slider.value += fillSpeed * Time.deltaTime;
        }
    }
    void incrementProgress(float additionalProgress)
    {
        targetProgess += additionalProgress;
    }
}
