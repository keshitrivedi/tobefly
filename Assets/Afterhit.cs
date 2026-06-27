using System.Collections;
using UnityEngine;

public class Afterhit : MonoBehaviour
{
    [SerializeField] private Projectile projectile;
    [SerializeField] private Nethit netScript;
    [SerializeField] private Bottlehit bottleScript;
    [SerializeField] private Groundhit groundScript;
    [SerializeField] private UnderNet underNetScript;
    [SerializeField] private OverNet overNetScript;
    [SerializeField] private Canvas afterHitCanvas;
    [SerializeField] private UnityEngine.UI.Image leftImg;
    [SerializeField] private UnityEngine.UI.Image rightImage;
    [SerializeField] private UnityEngine.UI.Image textImg;
    [SerializeField] private Sprite[] resSprites;
    [SerializeField] private Sprite[] suppSprites;
    [SerializeField] private Sprite[] textSprites;
    private int spriteind;
    private int suppSpriteInd;
    private int textSpriteInd;
    private bool gira = false;
    private bool actualHit = false;
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
            if (underNetScript.under && !overNetScript.netPaar && !actualHit && !netScript.nethit)
            {
                Debug.Log("Cue");
                spriteind = 3;
                suppSpriteInd = 2;
                textSpriteInd = 4;
            } else
            {
                if (netScript.nethit)
                {
                    // net panel
                    Debug.Log("NET");
                    spriteind = 2;
                    suppSpriteInd = 3;
                    textSpriteInd = 2;
                } else
                {
                    if (bottleScript.bottlehit && !groundScript.groundhit)
                    {
                        // hit panel
                        Debug.Log("HIT");
                        spriteind = 0;
                        suppSpriteInd = 0;
                        textSpriteInd = 0;
                        actualHit = true;
                    } else
                    {
                        if (!actualHit)
                        {
                            // miss panel
                            Debug.Log("MISS");
                            spriteind = 1;
                            suppSpriteInd = 1;
                            textSpriteInd = 1;
                        }
                    }
                }
            }

            if (groundScript.groundhit)
            {
                Debug.Log("hi");
                gira = true;
                //start delay counter
                StartCoroutine(delay(2));
                
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
        if (bottleScript.bottlehit && !underNetScript.under && !actualHit)
        {
            spriteind = 4;
            textSpriteInd = 3;
        }
        afterHitCanvas.gameObject.SetActive(true);
        leftImg.sprite = resSprites[spriteind];
        rightImage.sprite = suppSprites[suppSpriteInd];
        textImg.sprite = textSprites[textSpriteInd];
    }
}
