using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextAnimation : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _textMeshPro;

    public string[] stringArray;

    [SerializeField] float timeBwChars;
    [SerializeField] float timeBwWords;

    int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        EndCheck();
    }

    void EndCheck()
    {
        if(i<= stringArray.Length - 1)
        {
            _textMeshPro.text = stringArray[i];
            StartCoroutine(TextVisible());
        }
    }

    private IEnumerator TextVisible()
    {
        _textMeshPro.ForceMeshUpdate();
        int totalVisibleChars = _textMeshPro.textInfo.characterCount;
        int counter = 0;

        while (true)
        {
            int visibleCount = counter % (totalVisibleChars + 1);
            _textMeshPro.maxVisibleCharacters = visibleCount;

            if(visibleCount >= totalVisibleChars)
            {
                i += 1;
                Invoke("EndCheck", timeBwWords);
                break;
            }

            counter += 1;
            yield return new WaitForSeconds(timeBwChars);
        }
    }


}
