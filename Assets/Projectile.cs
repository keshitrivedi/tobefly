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
    [SerializeField] private float secondss = 5;
    private bool maaro = false;
    public bool ballReleased = false;

    [SerializeField] private LineRenderer lineRenderer;
    [SerializeField] private int linePoints = 1000;
    [SerializeField] private float timeIntervalInPoints = 0.05f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ballrb = ball.GetComponent<Rigidbody>();
        ball.transform.position = launchPoint.position;

        ballrb.constraints = RigidbodyConstraints.FreezePositionY;
        maaro = false;
        ballReleased = false;

        StartCoroutine(Timewr(secondss));
    }

    // Update is called once per frame
    void Update()
    {
        launchPoint.transform.rotation = controllerTransform.rotation;

        lineRenderer.enabled = !ballReleased;
        if (lineRenderer)
        {
            DrawTrajectory();
        }

        if (maaro) // Mouse.current.leftButton.isPressed
        {
            maaro = false;
            Debug.Log("maaroooo");
            ballrb.constraints = RigidbodyConstraints.None;
            ballrb.linearVelocity = launchSpeed * launchPoint.up;
        }
    }

    private IEnumerator Timewr(float secondss)
    {
        yield return new WaitForSeconds(secondss);
        maaro = true;
        ballReleased = true;
    }

    void DrawTrajectory()
    {
        Vector3 origin = launchPoint.position;
        Vector3 startVelocity = launchSpeed * launchPoint.up;
        lineRenderer.positionCount = linePoints;
        float time = 0;
        for (int i = 0; i < linePoints; i++)
        {
            // var x = (startVelocity.x * time) + (Physics.gravity.x / 2 * time * time);
            // var y = (startVelocity.y * time) + (Physics.gravity.y / 2 * time * time);
            // Vector3 point = new Vector3(x, y, 0);
            Vector3 point = origin + startVelocity * time + 0.5f * Physics.gravity * time * time;
            lineRenderer.SetPosition(i, point);
            time += timeIntervalInPoints;
        }
    }
}
