using UnityEngine;

public class OverNet : MonoBehaviour
{
    public bool netPaar = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ball")
        {
            netPaar = true;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
