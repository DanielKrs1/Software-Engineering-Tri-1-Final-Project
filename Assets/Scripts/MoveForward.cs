using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 4.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.right * Time.deltaTime * speed, Space.World);
    }
}
