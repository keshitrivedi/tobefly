using UnityEngine;

public class UnderNet : MonoBehaviour
{
    public bool under = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Awake()
    {
        under = false;
    }

    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ball")
        {
            Debug.Log("ay naughty");
            under = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
