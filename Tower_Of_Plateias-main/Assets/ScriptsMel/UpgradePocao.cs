using UnityEngine;

using System.Collections;

public class UpgradePocao: MonoBehaviour

{

    public int pontosPorClique = 1; // valor padrão

    private int multiplicador = 1;  // começa normal

    private bool pocaoAtiva = false;

    public void Clicar()

    {

        // Sempre multiplica pelo valor atual

        int ganho = pontosPorClique * multiplicador;

        // Aqui você soma os pontos no total do jogador

        Debug.Log("Ganhou " + ganho + " pontos!");

    }

    public void ComprarPocao()

    {

        if (!pocaoAtiva) // só ativa se não tiver uma já rodando

        {

            StartCoroutine(AtivarPocao());

        }

    }

    private IEnumerator AtivarPocao()

    {

        pocaoAtiva = true;

        multiplicador = 2; // dobra os ganhos

        Debug.Log("Poção ativada! Ganhos dobrados por 30 segundos.");

        yield return new WaitForSeconds(30f); // espera 30s

        multiplicador = 1; // volta ao normal

        pocaoAtiva = false;

        Debug.Log("Poção acabou! Ganhos voltaram ao normal.");

    }

}
