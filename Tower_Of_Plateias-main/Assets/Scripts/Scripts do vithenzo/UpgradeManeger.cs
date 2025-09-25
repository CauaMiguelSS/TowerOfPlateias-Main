using UnityEngine;
using TMPro;
public class UpgradeManeger : MonoBehaviour
{
    [SerializeField] TMP_Text countText;

    void Start()
    {
     countText.text = "Mortes: " + GameData.contador.ToString();
    }

    public static class GameData
    {
        public static int contador = 0;
    }



    void Update()
    {
        
    }
}
