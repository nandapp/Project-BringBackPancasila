using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Pause : MonoBehaviour {

    //public Canvas canvas;
    public Image img1;
    public Image img2;
    public CanvasGroup CG;
    public CanvasGroup UI_Sila;
    //public GameObject PlayerObject;

    private bool isPause = true;

    void Start()
    {
        //canvas = GetComponent<Canvas>();
        //canvas.enabled = false;
        img1.enabled = false;
        img2.enabled = false;

        CG.alpha = 0f;
        CG.interactable = false;
        CG.blocksRaycasts = false;

        UI_Sila.alpha = 1f;
        UI_Sila.interactable = true;
        UI_Sila.blocksRaycasts = true;

    }

    void Update()
    {
        isPause = !isPause;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPause == false)
            {
                Pause1();
            }
            else
            {
                NoPause();
            }
        }
    }

    public void NoPause()
    {
        img1.enabled = false;
        img2.enabled = false;

        CG.alpha = 0f;
        CG.interactable = false;
        CG.blocksRaycasts = false;

        UI_Sila.alpha = 1f;
        UI_Sila.interactable = true;
        UI_Sila.blocksRaycasts = true;

        Time.timeScale = 1;
    }

    public void Pause1()
    {
        // canvas.enabled = !canvas.enabled;
        img1.enabled = true;
        img2.enabled = true;

        CG.alpha = 1f;
        CG.interactable = true;
        CG.blocksRaycasts = true;

        UI_Sila.alpha = 0f;
        UI_Sila.interactable = false;
        UI_Sila.blocksRaycasts = false;

        Time.timeScale = 0;

        //Time.timeScale = Time.timeScale == 0 ? 1 : 0;
    }

    public void Quit()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
