using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearWhenProgressBarIsFull : MonoBehaviour

{
    // Start is called before the first frame update
    public ProgressBar progressBar;
    private float startingX = 13;
    private float endingX = 9;
    private float wallSpeed = 4;
    private bool isOnScreen = false;

    void Start()
    {
     
        resetPosition();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (progressBar.isFull() && isOnScreen == false)
        {
            StartCoroutine("objectAppears");
            isOnScreen = true;
        }

    }
    IEnumerator objectAppears()
    {
        while (transform.position.x > endingX)
        {
            transform.Translate(Vector3.left * Time.deltaTime * wallSpeed, Space.World);
            yield return null;
        }
        
    }
    void resetPosition()
    {
        transform.position = new Vector3(startingX, 0, 0);
        isOnScreen = false;
    }
}
