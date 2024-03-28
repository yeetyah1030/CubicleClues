using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        toHide1.SetActive(false);
        toHide2.SetActive(false);

        toShow1.SetActive(true);
    }


    public GameObject toHide1;
    public GameObject toHide2;
    public GameObject toShow1;
}
