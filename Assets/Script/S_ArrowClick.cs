using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_ArrowClick : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameObject1, gameObject2;

    void OnMouseDown()
    {
        gameObject1.SetActive(false);
        gameObject2.SetActive(true);
    }
}