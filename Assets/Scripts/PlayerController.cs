using System.Collections;
using System.Collections.Generic;
using UnityEditor.MPE;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    private new Camera camera;

    // Start is called before the first frame update

    public GameObject projectilePrefab;
    void Start()
    {
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {


        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput);

        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * Time.deltaTime * verticalInput);

        if (Input.GetMouseButtonDown(0))
        {
<<<<<<< HEAD

            Vector3 targetDirection = (Input.mousePosition - transform.position).normalized;
            Quaternion projectileRotation = Quaternion.Euler(targetDirection);
          

            Instantiate(projectilePrefab, transform.position, projectileRotation);
=======
            Vector3 mousePosition = camera.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0f;
            
            //do some trig
            Vector3 targetDir = mousePosition - transform.position;
            float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg;
            Instantiate(projectilePrefab, transform.position, Quaternion.Euler(0f, 0f, angle));
>>>>>>> c5f3fe67e40f8d3f1fd3d4a8770ed1a2a380d21e
        }

    }
    
}
