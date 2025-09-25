using UnityEngine;
public class ManagerGame : MonoBehaviour
{
    public static GameManager instance;
    public int multiplicador = 1;
    public float tempoRestante = 0f;
    private void Awake()
    {
        // Garante que s� exista 1 GameManager
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // n�o destr�i ao trocar de cena
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        if (tempoRestante > 0)
        {
            tempoRestante -= Time.deltaTime;
            if (tempoRestante <= 0)
            {
                multiplicador = 1; // volta ao normal
            }
        }
    }
    public void AtivarPocao(float duracao, int multi)
    {
        multiplicador = multi;
        tempoRestante = duracao;
    }
}