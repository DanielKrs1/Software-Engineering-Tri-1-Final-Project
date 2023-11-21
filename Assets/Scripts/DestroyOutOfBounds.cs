using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update

    public float upBound = 3;
    public float downBound = 3;
    public float leftBound = 3;
    public float rightBound = 3;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > upBound || transform.position.y < downBound)
        {
            Destroy(gameObject);
        }
        if (transform.position.x > rightBound || transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }
    }
}
