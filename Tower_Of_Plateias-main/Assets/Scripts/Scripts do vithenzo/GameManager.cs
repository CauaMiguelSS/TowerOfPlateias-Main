using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int TotalMortes = 0;
    public int valorDoClick = 1;
    public int contador = 0;

    public int mortesporsegundo = 0;
    public float tempoEntreAutoClicks = 1;
    private float cronometroAutoClick = 0f;
    public int moedasEspeciais = 0;     
    public int multiplicadoresAtivos = 0;
    public int limiteBonus = 300;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }
    }


    void Start()
    {
        
    }

    void Update()
    {
        if (mortesporsegundo > 0)
        {
            cronometroAutoClick += Time.deltaTime;
            if (cronometroAutoClick >= tempoEntreAutoClicks)
            {
                TotalMortes += mortesporsegundo;
                cronometroAutoClick = 0f;
            }
        }
    }


}
