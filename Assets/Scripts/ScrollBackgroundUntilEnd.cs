using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackgroundUntilEnd : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;
    // Start is called before the first frame update
    void Start()
    {
        // Get the width for scaling the background
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider2D>().size.x * transform.localScale.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        // TODO: Unit test
        // Only move if player hasn't hit the end of the level
        if (DataManager.Instance.distance < DataManager.Instance.maxDist)
        {
            transform.Translate(Vector3.left * Time.deltaTime * DataManager.Instance.scrollSpeed);
            // Move background back a length if past the threshhold to create the illusion of endless scrolling
            if (transform.position.x < startPos.x - repeatWidth)
            {
                transform.position = startPos;
            }
        }
    }
}
