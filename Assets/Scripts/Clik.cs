using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clik : MonoBehaviour
{
    //public GameObject effect_click;
    public ParticleSystem effect_click;
    public void Click_button()
    {
        effect_click.Play();
    }
}
