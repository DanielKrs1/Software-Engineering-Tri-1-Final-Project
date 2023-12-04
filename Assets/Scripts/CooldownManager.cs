using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CooldownManager : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerStatistics playerStatistics;
    Renderer ren;
    public Color ableToFireColor = new Vector4(0, 0.75f, 0.25f, 1);
    public Color unableToFireColor = new Vector4(1, 0.25f, 0, 1);

    private float lastFireTime = 0;
    void Start()
    {
        ren= GetComponent<Renderer>();
        ren.material.SetColor("_Color", new Vector4(1, 0.5f, 0, 1));
    }

    public bool canFire()
    {
        return Time.time - playerStatistics.projectileCooldownTime > lastFireTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (canFire())
        {
            
            ren.material.SetColor("_Color", ableToFireColor * 2.5f);
        }
        else
        {
            
            ren.material.SetColor("_Color", unableToFireColor * 2.5f);
        }
    }
    public void resetCooldown()
    {
        lastFireTime = Time.time;
    }
}
