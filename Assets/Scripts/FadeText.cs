using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FadeText : MonoBehaviour
{
    public float FadeTime = 1f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Fade(GetComponent<TextMeshProUGUI>()));
    }

    // Slowly fade text and then destroy it
    public IEnumerator Fade(TextMeshProUGUI text)
    {
        float time = 0;
        while (time < FadeTime)
        {
            time += Time.deltaTime;
            text.color = new Color(text.color.r, text.color.g, text.color.b, 1 - time / FadeTime);
            yield return null;
        }
        Destroy(gameObject);
    }
}
