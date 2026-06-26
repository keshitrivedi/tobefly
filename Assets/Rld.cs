using UnityEngine;
using UnityEngine.SceneManagement;

public class Rld : MonoBehaviour
{
    public void playAgain ()
    {
        Debug.Log("clickclick");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
