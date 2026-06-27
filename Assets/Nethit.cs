using UnityEngine;

public class Nethit : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    private Rigidbody ballrb;
    public bool nethit = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nethit = false;
        ballrb = ball.GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            if (ballrb.linearVelocity.z < 0)
            {
                nethit = true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
