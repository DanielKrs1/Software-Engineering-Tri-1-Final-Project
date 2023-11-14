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
        if (DataManager.Instance.distance < DataManager.Instance.maxDist)
        {
            transform.Translate(Vector3.left * Time.deltaTime * (speed ?? DataManager.Instance.scrollSpeed));
        }
        if (transform.position.x < DataManager.Instance.leftBound)
        {
            Destroy(gameObject);
        }
    }
}
