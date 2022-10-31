using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hole : MonoBehaviour
{
    bool entered = false;

    public bool Entered => entered;

    private void OnTriggerEnter(Collider other)
    {       
        entered = true;
    }
}
