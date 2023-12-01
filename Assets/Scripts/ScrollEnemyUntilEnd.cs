using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollEnemyUntilEnd : MonoBehaviour
{
    public float? speed = null;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Move left if player hasn't hit the end of the level
        if (DataManager.Instance.distance < DataManager.Instance.maxDist)
        {
            // Can set a speed for this object, otherwise use the default
            transform.Translate(Vector3.left * Time.deltaTime * (speed ?? DataManager.Instance.scrollSpeed));
        }
        // Kill object if it goes off screen
        // TODO: Unit tests
        if (transform.position.x < DataManager.Instance.leftBound)
        {
            Destroy(gameObject);
        }
    }
}
