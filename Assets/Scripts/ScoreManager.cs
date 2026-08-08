using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoretext;

    private int scoreMoedas = 0;

    void Start()
    {
        AtualizarTexto();
    }
    
    public void AdicionarPontos(int pontos)
    {

        scoreMoedas += pontos;
        AtualizarTexto();

    }
    
    void AtualizarTexto()
    {

        scoretext.text = "Pontos: " + scoreMoedas;

    }
    
}
