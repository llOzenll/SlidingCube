using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject CanvasWin;
    public PlayerMovement playerMovement;

    private void OnTriggerEnter2D(Collider2D other)
    {
        playerMovement.rigidbody.gravityScale = 1;
        CanvasWin.SetActive(true);
        Time.timeScale = 0;
    }
}
