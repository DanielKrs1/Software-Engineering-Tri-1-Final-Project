using System.Collections;
using System.Collections.Generic;
using UnityEditor.MPE;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject projectilePrefab;
    void Start()
    {
        
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
            
            Vector3 targetDir = Input.mousePosition - transform.position;
            Quaternion projectileRotation = transform.rotation;
            projectileRotation.z = Vector3.Angle(targetDir, Vector3.up);

            Instantiate(projectilePrefab, transform.position, transform.rotation);
        }

    }
    
}
