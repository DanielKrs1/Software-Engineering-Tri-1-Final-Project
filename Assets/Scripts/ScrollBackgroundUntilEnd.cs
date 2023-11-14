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
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider2D>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (DataManager.Instance.distance < DataManager.Instance.maxDist)
        {
            transform.Translate(Vector3.left * Time.deltaTime * DataManager.Instance.scrollSpeed);
            if (transform.position.x < startPos.x - repeatWidth)
            {
                transform.position = startPos;
            }
        }
    }
}
