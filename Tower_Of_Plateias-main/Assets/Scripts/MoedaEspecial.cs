using UnityEngine;
using UnityEngine.UI;

public class MoedaEspecialSystem : MonoBehaviour
{
    public int pontos = 0;                
    public int moedasEspeciais = 0;        
    public int limiteParaMoeda = 300;     

    public Text pontosText;
    public Text moedasEspeciaisText;

    void Update()
    {

        pontosText.text = "Pontos: " + pontos;
        moedasEspeciaisText.text = "Moedas Especiais: " + moedasEspeciais;

        if (pontos >= limiteParaMoeda)
        {
            GanharMoedaEspecial();
        }

    }

    public void Clique()
    {
        pontos++;
    }

    void GanharMoedaEspecial()
    {
        moedasEspeciais++;

        pontos = 0;


    }
}

