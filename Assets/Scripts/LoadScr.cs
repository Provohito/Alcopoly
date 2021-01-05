using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadScr : MonoBehaviour
{
    [SerializeField]
    private Image fillground;
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            StartCoroutine("Fade");
        }
    }
    IEnumerator Fade()
    {
        for (float ft = fillground.fillAmount; ft <= 1; ft += 0.0025f)
        {
            fillground.fillAmount += ft;
            yield return new WaitForSeconds(.1f);
        }
    }
}
