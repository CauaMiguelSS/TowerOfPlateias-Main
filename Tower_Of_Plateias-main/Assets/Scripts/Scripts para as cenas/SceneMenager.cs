using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneMenager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TrocaDeTela()
    {
        SceneManager.LoadScene("Game");
    }

    public void TrocaDeCena()
    {
        SceneManager.LoadScene("Upgrades");
    }
}
