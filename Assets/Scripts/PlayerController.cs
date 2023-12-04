using System.Collections;
using System.Collections.Generic;
using UnityEditor.MPE;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    private new Camera camera;
    private float distanceFromLeft = -6;


    private float speedMultiplier = 5;

    private float upperBorder = 4;
    private float lowerBorder = -4;

    private float leftBorder = -7;
    private float rightBorder = -5;

    private float lastFireTime = 0;
   

    // Start is called before the first frame update


    public GameObject projectilePrefab;
    public PlayerStatistics playerStatistics;

    public CooldownManager cooldown;
  

    void Start()
    {

        camera = Camera.main;
        transform.position = new Vector3(distanceFromLeft, 0, 0);
        
    }

    // Update is called once per frame
    void setPositionX(float newX)
    {
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }

    void setPositionY(float newY)
    {
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }

    void setPositionZ(float newZ)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, newZ);
    }

   
    void Update()
    {
        // Movement input 

        float horizontalInput = Input.GetAxis("Horizontal");
       
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speedMultiplier);

        if (transform.position.x > rightBorder)
        {
            setPositionX(rightBorder);
        }
        if (transform.position.x < leftBorder)
        {
            setPositionX(leftBorder);
        }


        float verticalInput = Input.GetAxis("Vertical");
       
        transform.Translate(Vector3.up * Time.deltaTime * verticalInput * speedMultiplier);
        

        if (transform.position.y > upperBorder)
        {
            setPositionY(upperBorder);
        }
        if (transform.position.y < lowerBorder)
        {
            setPositionY(lowerBorder);
        }
        // 


        // Projectile creation

        if (Input.GetMouseButtonDown(0) && cooldown.canFire())
        {
            Vector3 mousePosition = camera.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0f;
            
            //do some trig
            Vector3 targetDir = mousePosition - transform.position;
            float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg;
            Instantiate(projectilePrefab, transform.position, Quaternion.Euler(0f, 0f, angle));
            cooldown.resetCooldown();
        }

        //

    }
    
}
