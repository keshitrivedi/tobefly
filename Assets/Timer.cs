using System.Collections;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private UnityEngine.UI.Image timerDisplay;
    [SerializeField] private Sprite[] nums;
    [SerializeField] private Projectile ballwa;
    [SerializeField] private RectTransform leftSprPan;
    private int counter = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timerDisplay.sprite = nums[0];
        StartCoroutine(timer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator timer()
    {
        for (int i = 0; i < nums.Length; i++)
        {
            timerDisplay.sprite = nums[i];
            if (i == nums.Length - 1) // GO
            {
                ballwa.ballFenko();
            }
            yield return new WaitForSeconds(1);
        }

        timerDisplay.gameObject.SetActive(false);
        leftSprPan.anchoredPosition = new Vector2(20f, leftSprPan.anchoredPosition.y);
    }
}
