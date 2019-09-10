using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class bManager : MonoBehaviour {

    public CanvasGroup uiCanvasGroup;
    public CanvasGroup confirmQuitCanvasGroup;
    public Image img1;
    public Image img2;
    public Image img3;

    public void NewGameBtn(string newGameLevel)
    {
        SceneManager.LoadScene(newGameLevel);
    }

    private void Awake()
    {
        //disable the quit confirmation panel
        DoConfirmQuitNo();
		Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void control()
    {
        img1.enabled = true;
        img2.enabled = false;
        img3.enabled = false;
        uiCanvasGroup.alpha = 0f;
        uiCanvasGroup.interactable = false;
        uiCanvasGroup.blocksRaycasts = false;
    }

    public void credits()
    {
        img1.enabled = false;
        img3.enabled = false;
        img2.enabled = true;
        uiCanvasGroup.alpha = 0f;
        uiCanvasGroup.interactable = false;
        uiCanvasGroup.blocksRaycasts = false;
    }

    /// <summary>
    /// Called if clicked on No (confirmation)
    /// </summary>
    public void DoConfirmQuitNo()
    {
        Debug.Log("Back to the game");
        //enable the normal ui
        uiCanvasGroup.alpha = 1;
        uiCanvasGroup.interactable = true;
        uiCanvasGroup.blocksRaycasts = true;

        //disable the confirmation quit ui
        confirmQuitCanvasGroup.alpha = 0;
        confirmQuitCanvasGroup.interactable = false;
        confirmQuitCanvasGroup.blocksRaycasts = false;

        img1.enabled = false;
        img2.enabled = false;
        img3.enabled = true;
    }

    /// <summary>
    /// Called if clicked on Yes (confirmation)
    /// </summary>
    public void DoConfirmQuitYes()
    {
        Debug.Log("Ok bye bye");
        Application.Quit();
    }

    /// <summary>
    /// Called if clicked on Quit
    /// </summary>
    public void DoQuit()
    {
        Debug.Log("Check form quit confirmation");

        //reduce the visibility of normal UI, and disable all interraction
        uiCanvasGroup.alpha = 0f;
        uiCanvasGroup.interactable = false;
        uiCanvasGroup.blocksRaycasts = false;

        //enable interraction with confirmation gui and make visible
        confirmQuitCanvasGroup.alpha = 1;
        confirmQuitCanvasGroup.interactable = true;
        confirmQuitCanvasGroup.blocksRaycasts = true;
    }

    /// <summary>
    /// Called if clicked on new game (example)
    /// </summary>
    public void DoNewGame()
    {
        Debug.Log("Launch a new game");
    }
}
