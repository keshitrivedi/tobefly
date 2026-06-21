using System.Collections;
using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.InputSystem;

public class Projectile : MonoBehaviour
{
    [SerializeField] private Transform launchPoint;
    [SerializeField] private GameObject ball;
    private Rigidbody ballrb;
    [SerializeField] private float launchSpeed = 10f;
    [SerializeField] private Transform controllerTransform;
    [SerializeField] private float secondss = 3;
    private bool maaro = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ballrb = ball.GetComponent<Rigidbody>();
        ball.transform.position = launchPoint.position;

        ballrb.constraints = RigidbodyConstraints.FreezePositionY;
        maaro = false;

        StartCoroutine(Timewr(secondss));
    }

    // Update is called once per frame
    void Update()
    {
        ball.transform.rotation = controllerTransform.rotation;
        if (maaro) // Mouse.current.leftButton.isPressed
        {
            maaro = false;
            Debug.Log("maaroooo");
            ballrb.constraints = RigidbodyConstraints.None;
            ballrb.linearVelocity = launchSpeed * controllerTransform.up;
        }
    }

    private IEnumerator Timewr(float secondss)
    {
        yield return new WaitForSeconds(secondss);
        maaro = true;
    }
}
