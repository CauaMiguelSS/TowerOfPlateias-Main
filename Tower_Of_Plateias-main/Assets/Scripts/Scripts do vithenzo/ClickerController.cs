using UnityEngine;

using TMPro;

using UnityEngine.SceneManagement;

public class ClickerController : MonoBehaviour

{

    [SerializeField] TMP_Text countText;

    int contadorVitoria = 4000;

    [Header("Crítico")]

    [SerializeField] float chanceCritico = 0.1f;

    [SerializeField] int multiplicadorCritico = 2;

    void Update()

    {

        AtualizarTexto();

    }

    public void AoClicar()

    {

        int valor = GameManager.instance.valorDoClick;


        if (Random.value < chanceCritico)

        {

            valor *= multiplicadorCritico;

            Debug.Log("🔥 Crítico! +" + valor);

        }

        GameManager.instance.TotalMortes += valor;

        AtualizarTexto();

        if (GameManager.instance.TotalMortes >= contadorVitoria)

        {

            SceneManager.LoadScene("História");

        }

    }

    private void AtualizarTexto()

    {

        countText.text = "Mortes: " + GameManager.instance.TotalMortes.ToString();

    }

    public void Upgrades()

    {

        int custoUpgrade = 10;

        if (GameManager.instance.TotalMortes >= custoUpgrade)

        {

            GameManager.instance.TotalMortes -= custoUpgrade;

            GameManager.instance.valorDoClick += 1;

            AtualizarTexto();

        }

    }

    public void upgradePassivo()

    {

        int custoUpgradePassivo = 50;

        if (GameManager.instance.TotalMortes >= custoUpgradePassivo)

        {

            GameManager.instance.TotalMortes -= custoUpgradePassivo;

            GameManager.instance.mortesporsegundo += 1;

            AtualizarTexto();

        }

    }

}
