using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvoManager : MonoBehaviour
{
    public void hideConvo()
    {
        toHide1.SetActive(false);
        toHide2.SetActive(false);
    }

    public void showConvo()
    {
        toShow1.SetActive(true);
    }

    public GameObject toHide1;
    public GameObject toHide2;
    public GameObject toShow1;
}
