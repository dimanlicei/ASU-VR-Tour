using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QUESTMANAGER : MonoBehaviour
{
    public void Button(GameObject objects)
    {
        if (objects.active != true) { objects.SetActive(true); }
        else if (objects.active == true) { objects.SetActive(false); }
    }
}
