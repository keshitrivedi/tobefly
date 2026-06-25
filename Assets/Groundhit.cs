using UnityEngine;

public class Groundhit : MonoBehaviour
{
    public bool groundhit = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        groundhit = false;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            groundhit = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
