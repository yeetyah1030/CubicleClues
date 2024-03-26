using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneEndingFail : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("ending_fail", LoadSceneMode.Single);
    }
}

