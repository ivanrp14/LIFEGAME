using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeButton : MonoBehaviour
{
    public GameObject textCanvas;
    public GameObject uiCanvas;
    // Start is called before the first frame update
    public void Resume()
    {
        textCanvas.SetActive(false);
        uiCanvas.SetActive(true);
        Time.timeScale= 1f;
        Debug.Log("Clicked ResumeButton");
    }
}
