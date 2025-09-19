using UnityEngine;
using TMPro;
public class UpgradeManeger : MonoBehaviour
{
    [SerializeField] TMP_Text countText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     countText.text = "Mortes: " + GameData.contador.ToString();
    }

    public static class GameData
    {
        public static int contador = 0;
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
