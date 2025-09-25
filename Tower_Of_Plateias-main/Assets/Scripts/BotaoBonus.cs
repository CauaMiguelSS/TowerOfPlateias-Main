using UnityEngine;
using TMPro;

public class BotaoBonus : MonoBehaviour
{
    public GameObject botaoBonus;
    public TMP_Text textoMultiplicadores;

    void Update()
    {

        if (GameManager.instance.TotalMortes >= 300)
        {
            botaoBonus.SetActive(true);
        }
        else
        {
            botaoBonus.SetActive(false);
        }


        textoMultiplicadores.text = "Multiplicadores: " + GameManager.instance.multiplicadoresAtivos;
    }

    public void AtivarBonus()
    {
        if (GameManager.instance.TotalMortes >= 300)
        {
         
            GameManager.instance.valorDoClick *= 2;

        
            GameManager.instance.mortesporsegundo *= 2;

           
            GameManager.instance.TotalMortes = 0;

            
            GameManager.instance.multiplicadoresAtivos++;

           
            botaoBonus.SetActive(false);
        }
        else
        {
            Debug.Log("Você precisa de pelo menos 300 pontos para usar o bônus!");
        }
    }
}

