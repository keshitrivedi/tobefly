using System.Collections;
using UnityEngine.UI;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class Afterhit : MonoBehaviour
{
    [SerializeField] private Projectile projectile;
    [SerializeField] private Nethit netScript;
    [SerializeField] private Bottlehit bottleScript;
    [SerializeField] private Groundhit groundScript;
    [SerializeField] private Canvas afterHitCanvas;
    [SerializeField] private UnityEngine.UI.Image leftImg;
    [SerializeField] private UnityEngine.UI.Image rightImage;
    [SerializeField] private Sprite[] resSprites;
    private int spriteind;
    private bool gira = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        afterHitCanvas.gameObject.SetActive(false);
        gira = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (projectile.ballReleased)
        {
            if (netScript.nethit)
            {
                // net panel
                Debug.Log("NET");
                spriteind = 2;
            } else
            {
                if (bottleScript.bottlehit)
                {
                    // hit panel
                    Debug.Log("HIT");
                    spriteind = 0;
                } else
                {
                    // miss panel
                    Debug.Log("MISS");
                    spriteind = 1;
                }
            }

            if (groundScript.groundhit)
            {
                Debug.Log("hi");
                gira = true;
                //start delay counter
                StartCoroutine(delay(5));
                
            }
            // check if collider of net hit
                // check if same side of the ground hit or velocity in z towards you
                    // net bool
            // else
                // check if collider of bottle hit
                    // hit bool
                // else
                    // miss bool
            // insert delay
            // enable canvas transition
        }
        
    }

    private IEnumerator delay(float secondss)
    {
        yield return new WaitForSeconds(secondss);
        Debug.Log("ground is hit");
        afterHitCanvas.gameObject.SetActive(true);
        leftImg.sprite = resSprites[spriteind];
    }
}
