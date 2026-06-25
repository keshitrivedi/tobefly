using UnityEngine;

public class Bottlehit : MonoBehaviour
{
    public bool bottlehit;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bottlehit = false;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            bottlehit = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
