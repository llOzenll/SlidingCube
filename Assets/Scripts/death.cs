using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{
    public GameObject CanvasDeath;

    private void OnTriggerEnter2D(Collider2D other)
    {
        CanvasDeath.SetActive(true);
        Time.timeScale = 0;
    }
}

