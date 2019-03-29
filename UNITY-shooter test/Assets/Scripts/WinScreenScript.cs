using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreenScript : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene(0);
    }
}