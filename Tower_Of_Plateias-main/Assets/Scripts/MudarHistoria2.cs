using UnityEngine;
using UnityEngine.SceneManagement;

public class MudarHistoria2 : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("Historia3");
    }

    public void LoadScene1()
    {
        SceneManager.LoadScene("Historia2");
    }
    public void LoadScene2()
    {
        SceneManager.LoadScene("Start");
    }
}