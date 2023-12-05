using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneFader : MonoBehaviour {
    private static SceneFader instance;

    private static SceneFader I {
        get {
            if (instance == null) {
                instance = Instantiate(Resources.Load<SceneFader>("Scene Fader"));
                DontDestroyOnLoad(instance);
            }

            return instance;
        }
    }

    private void Start() {
        
    }

    public static void FadeTo(string sceneName) {

    }
}