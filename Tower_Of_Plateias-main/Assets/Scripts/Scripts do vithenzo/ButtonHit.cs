using UnityEngine;
using TMPro;

public class LojaController : MonoBehaviour
{
    public GameObject botaoBonus;          // botão de multiplicador
    public TMP_Text textoMultiplicadores;  // texto mostrando quantos multiplicadores

    void Start()
    {
        botaoBonus.SetActive(false); // começa invisível
    }

    void Update()
    {
        if (GameManager.instance.TotalMortes >= 300)
            botaoBonus.SetActive(true);
        else
            botaoBonus.SetActive(false);

        textoMultiplicadores.text = "Multiplicadores: " + GameManager.instance.multiplicadoresAtivos;
    }

    public void AtivarBonus()
    {
        if (GameManager.instance.TotalMortes >= 300)
        {
            GameManager.instance.valorDoClick *= 2;
            GameManager.instance.TotalMortes = 0;
            GameManager.instance.multiplicadoresAtivos++;
            botaoBonus.SetActive(false);
        }
    }
}

