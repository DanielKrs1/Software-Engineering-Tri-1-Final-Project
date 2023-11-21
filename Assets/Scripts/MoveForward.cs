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
<<<<<<< HEAD
        transform.Translate(Vector3.up * Time.deltaTime * speed);
=======
        transform.Translate(transform.right * Time.deltaTime * speed, Space.World);
>>>>>>> c5f3fe67e40f8d3f1fd3d4a8770ed1a2a380d21e
    }
}
