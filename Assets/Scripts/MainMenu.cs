using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string firstLevel;

    public Image blackScreen;
    public float fadeSpeed = 1f;
    public bool fadeToBlack, fadeFromBlack;
    public GameObject controls, title, startButton, exitButton;

    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    void Update()
    {
        if (fadeToBlack)
        {
            blackScreen.color = new Color(blackScreen.color.r, blackScreen.color.g, blackScreen.color.b, Mathf.MoveTowards(blackScreen.color.a, 1f, fadeSpeed * Time.deltaTime));

            if (blackScreen.color.a == 1f)
            {
                fadeToBlack = false;
            }
        }

        if (fadeFromBlack)
        {
            blackScreen.color = new Color(blackScreen.color.r, blackScreen.color.g, blackScreen.color.b, Mathf.MoveTowards(blackScreen.color.a, 0f, fadeSpeed * Time.deltaTime));

            if (blackScreen.color.a == 0f)
            {
                fadeFromBlack = false;
            }
        }
    }

    public void NewGame()
    {
        StartCoroutine(NewGameCo());
    }

    public void QuitGame()
    {
        StartCoroutine(QuitCo());
    }

    IEnumerator NewGameCo()
    {
        fadeToBlack = true;
        yield return new WaitForSeconds(2f);
        title.SetActive(false);
        startButton.SetActive(false);
        exitButton.SetActive(false);
        controls.SetActive(true);
        fadeFromBlack = true;
        yield return new WaitForSeconds(6f);
        fadeToBlack = true;
        yield return new WaitForSeconds(2f);
        controls.SetActive(false);

        SceneManager.LoadScene(firstLevel);
    }

    IEnumerator QuitCo()
    {
        fadeToBlack = true;
        yield return new WaitForSeconds(2f);
        Application.Quit();
    }
}
