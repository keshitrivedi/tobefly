using System;
using System.Collections;
using Microsoft.Unity.VisualStudio.Editor;
using Unity.VisualScripting;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private UnityEngine.UI.Image timerDisplay;
    [SerializeField] private Sprite[] nums;
    private int counter = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timerDisplay.sprite = nums[0];
        StartCoroutine(timer(5));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator timer(float secondss)
    {
        while (counter < secondss)
        {
            counter ++;
            timerDisplay.sprite = nums[counter];
            yield return new WaitForSeconds(1);
        }
        yield return new WaitForSeconds(1.5f);
        timerDisplay.gameObject.SetActive(false);
    }
}
