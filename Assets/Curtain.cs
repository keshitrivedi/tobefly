using Microsoft.Unity.VisualStudio.Editor;
using Unity.VisualScripting;
using UnityEngine;

public class Curtain : MonoBehaviour
{
    [SerializeField]private RectTransform leftPanel;
    [SerializeField] private RectTransform rightPanel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        leftPanel.anchoredPosition = new Vector2(-401f, leftPanel.anchoredPosition.y);
        rightPanel.anchoredPosition = new Vector2(401f, rightPanel.anchoredPosition.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (leftPanel.anchoredPosition.x < 0)
        {
            float leftX = leftPanel.anchoredPosition.x + 1f;
            float rightX = rightPanel.anchoredPosition.x - 1f;

            leftPanel.anchoredPosition = new Vector2(leftX, leftPanel.anchoredPosition.y);
            rightPanel.anchoredPosition = new Vector2(rightX, rightPanel.anchoredPosition.y);
        }
    }
}
