using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class Ghumao : MonoBehaviour
{
    [SerializeField] private InputAction pressed, axis;
    [SerializeField] private float speed;
    private Vector2 rotation;
    private bool rotateAllowed;

    private void Awake()
    {
        pressed.Enable();
        axis.Enable();
        pressed.performed += _ => {StartCoroutine(Rotate());};
        pressed.canceled += _ => {rotateAllowed = false;};

        axis.performed += context => {rotation = context.ReadValue<Vector2>();};
    }

    private IEnumerator Rotate()
    {
        rotateAllowed = true;
        while(rotateAllowed)
        {
            rotation *= speed;
            transform.Rotate(-Vector3.up, rotation.x, Space.World);
            transform.Rotate(Vector3.right, rotation.y);
            yield return null;
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
