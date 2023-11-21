using System.Collections;
using System.Collections.Generic;
using UnityEditor.MPE;
using UnityEngine;
using UnityEngine.UIElements;

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

            Vector3 targetDirection = (Input.mousePosition - transform.position).normalized;
            Quaternion projectileRotation = Quaternion.Euler(targetDirection);
          

            Instantiate(projectilePrefab, transform.position, projectileRotation);
        }

    }
    
}
