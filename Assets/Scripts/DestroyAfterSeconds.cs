using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterSeconds : MonoBehaviour {
    [SerializeField] private float destroyTime;

    private void Start() {
        Destroy(gameObject, destroyTime);
    }
}
