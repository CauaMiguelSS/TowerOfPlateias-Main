using UnityEngine;
public class ManagerGame : MonoBehaviour
{
    public static GameManager instance;
    public int multiplicador = 1;
    public float tempoRestante = 0f;
    private void Awake()
    {
        
    }
    private void Update()
    {
        if (tempoRestante > 0)
        {
            tempoRestante -= Time.deltaTime;
            if (tempoRestante <= 0)
            {
                multiplicador = 1;
            }
        }
    }
    public void AtivarPocao(float duracao, int multi)
    {
        multiplicador = multi;
        tempoRestante = duracao;
    }
}