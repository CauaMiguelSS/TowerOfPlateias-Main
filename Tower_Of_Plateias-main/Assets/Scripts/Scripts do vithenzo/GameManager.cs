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

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(mortesporsegundo > 0)
        {
            cronometroAutoClick += Time.deltaTime;
            if(cronometroAutoClick >= tempoEntreAutoClicks)
            {
                TotalMortes += mortesporsegundo;
                cronometroAutoClick = 0f;
              
            }
        }
    }
}
