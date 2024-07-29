using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    public GameObject CanvasMenu;
    public GameObject CanvasDeath;
    public GameObject CanvasWin;
    public PlayerMovement playerMovement;


    private void Start()
    {
        Time.timeScale = 0f;
    }
    public void Play()
    {
        Time.timeScale = 1;
        CanvasDeath.SetActive(false);
        CanvasWin.SetActive(false);
        CanvasMenu.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Retry()
    {
        Time.timeScale = 1;
        CanvasDeath.SetActive(false);
        CanvasWin.SetActive(false);

        playerMovement.ResetPosition();
        playerMovement.canSlide = false;
    }

    public void Menu()
    {
        CanvasDeath.SetActive(false);
        CanvasWin.SetActive(false);
        CanvasMenu.SetActive(true);

        playerMovement.ResetPosition();
        playerMovement.canSlide = false;
        Time.timeScale = 0;
    }

}
