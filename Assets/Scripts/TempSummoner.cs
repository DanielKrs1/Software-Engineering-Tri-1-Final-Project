using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempSummoner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    void Start()
    {
        InvokeRepeating("Spawn", 2.0f, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Spawn()
    {
        if (DataManager.Instance.distance < DataManager.Instance.maxDist)
            Instantiate(prefab, new Vector3(25, Random.Range(-3.0f, 3.0f), 0), Quaternion.identity);
    }
}
