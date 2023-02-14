using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextButton : MonoBehaviour
{
    public GameObject textCanvas;
    public GameObject uiCanvas;

    public void TextMode()
    {
        Debug.Log("Clicked TextButton");
        Time.timeScale= 0f;
        uiCanvas.SetActive(false);
        textCanvas.SetActive(true);

    }
}
