using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ButtonHit : MonoBehaviour
{
    [SerializeField] TMP_Text countText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void ClickMorte()
    {
        GameData.contador++;
        UpdateUI();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void trocaDeCena()
    {
        SceneManager.LoadScene("Upgrades");
    }
    private void UpdateUI()
    {
        countText.text = "Mortes: " + GameData.contador.ToString();
    }

    public static class GameData
    {
        public static int contador = 0;
    }
}
