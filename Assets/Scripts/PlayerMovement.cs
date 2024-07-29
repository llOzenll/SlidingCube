using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    Vector2 IniPosition;
    private Touch touch;

    public bool isCollidingWithGround;
    private bool touched;
    public bool canSlide;
    private float speed = 7f;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        GameObject gameObject = GetComponent<GameObject>();
        IniPosition = transform.position;
        touched = false;
        isCollidingWithGround = false;

        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = -1;
    }

    private void Update()
    {
        if (canSlide) Slide();

        if (Input.touchCount > 0) TouchMove();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("ground"))
        {
            isCollidingWithGround = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("ground"))
        {
            isCollidingWithGround = false;
        }
    }

    public void Slide()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    public void TouchMove()
    {
        touch = Input.GetTouch(0);

        if (touch.phase == TouchPhase.Ended && isCollidingWithGround)
        {
            canSlide = true;

            if (!touched)
            {
                rigidbody.gravityScale = -15;
                touched = true;
            }
            else
            {
                rigidbody.gravityScale = 15;
                touched = false;
            }
        }
    }

    public void ResetPosition()
    {
        gameObject.transform.position = IniPosition;
    }
}
