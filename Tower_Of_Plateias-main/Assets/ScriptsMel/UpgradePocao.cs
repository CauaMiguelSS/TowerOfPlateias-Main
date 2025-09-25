using UnityEngine;

using System.Collections;

public class UpgradePocao: MonoBehaviour

{

    public int pontosPorClique = 1; // valor padr�o

    private int multiplicador = 1;  // come�a normal

    private bool pocaoAtiva = false;

    public void Clicar()

    {

        // Sempre multiplica pelo valor atual

        int ganho = pontosPorClique * multiplicador;

        // Aqui voc� soma os pontos no total do jogador

        Debug.Log("Ganhou " + ganho + " pontos!");

    }

    public void ComprarPocao()

    {

        if (!pocaoAtiva) // s� ativa se n�o tiver uma j� rodando

        {

            StartCoroutine(AtivarPocao());

        }

    }

    private IEnumerator AtivarPocao()

    {

        pocaoAtiva = true;

        multiplicador = 2; // dobra os ganhos

        Debug.Log("Po��o ativada! Ganhos dobrados por 30 segundos.");

        yield return new WaitForSeconds(30f); // espera 30s

        multiplicador = 1; // volta ao normal

        pocaoAtiva = false;

        Debug.Log("Po��o acabou! Ganhos voltaram ao normal.");

    }

}
