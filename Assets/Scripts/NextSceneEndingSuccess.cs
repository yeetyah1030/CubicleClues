using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("ending_success", LoadSceneMode.Single);
    }
}
