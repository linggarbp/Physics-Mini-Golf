using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource click;
    [SerializeField] AudioSource bgm;

    public void Click()
    {
        click.Play();
    }
}
