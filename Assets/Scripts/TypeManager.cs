using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// imports
using UnityEngine.UI;
using TMPro;


public class Typing : MonoBehaviour
{
    public TextMeshProUGUI textTypeOut;
    public string textShow;

    public void ShowText()
    {
        StartCoroutine(TextTypeOutCoroutine());
    }

    IEnumerator TextTypeOutCoroutine()
    {
        // clear previous text
        textTypeOut.text = "";

        // displaying char by char
        foreach (char letter in textShow)
        {
            textTypeOut.text += letter;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
