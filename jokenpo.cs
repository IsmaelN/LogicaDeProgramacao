using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Jokepo : MonoBehaviour
{
    // 1= Pedra - 2= Papel - 3= Tesoura
    // 1 > 3 ||| 3 > 2 ||| 2 > 1  ||| Empates

    //private int iPedra = 1;
    //private int iPapel = 2;
    //private int iTesoura = 3;
    public int iNumeroDeJogadas = 3;
    private int iJogador = 0; 
    private int iMaquina;
    private int iPontosJogador = 0;
    private int iPontosMaquina = 0;
    public Text tResultado;
    public Text tJogadaDaMaquina;
    public Text tPontosJogador;
    public Text tPontosMaquina;
    public Text tNumeroDeJogadas;
    public GameObject goPedra;
    public GameObject goPapel;
    public GameObject goTesoura;

    public void Update()
    {
        //Exibindo pontuação do jogador, IA e jogadas restantes.
        tPontosJogador.GetComponent<Text>().text = "Jogador = " + iPontosJogador ;
        tPontosMaquina.GetComponent<Text>().text = "Máquina = " + iPontosMaquina;

        tNumeroDeJogadas.GetComponent<Text>().text = "Jogadas Restantes: " + iNumeroDeJogadas.ToString();
    }

    public void ReiniciaJogada()
    {
        //carregando a cena novamente.
        Application.LoadLevel(0);
    }

    public void Maquina()
    {
        //Jogada da Maquina
        iMaquina = Random.Range(1, 4);

        //Verificando resultados da Maquina para a Pedra(1).
        if ((iMaquina == 1) && (iJogador == 1))
        {
            //Debug.Log(" Jogador Empatou com a Maquina ");
            //tResultado.GetComponent<Text>().text = "Jogador Empatou com a Máquina";
        }

        if ((iMaquina == 1) && (iJogador == 2))
        {
            //Debug.Log(" Jogador ganhou da Maquina ");
            //tResultado.GetComponent<Text>().text = "Jogador ganhou da Máquina";
            iPontosJogador += 1;
        }

        if ((iMaquina == 1) && (iJogador == 3))
        {
            //Debug.Log(" Maquina ganhou do jogador ");
            //tResultado.GetComponent<Text>().text = "Máquina ganhou do jogador";
            iPontosMaquina += 1;
        }

        //Verificando resultados da Maquina para a Papel(2).
        if ((iMaquina == 2) && (iJogador == 1))
        {
            //Debug.Log(" Maquina ganhou do jogador ");
            //tResultado.GetComponent<Text>().text = "Máquina ganhou do jogador";
            iPontosMaquina += 1;
        }

        if ((iMaquina == 2) && (iJogador == 2))
        {
            //Debug.Log(" Jogador Empatou com a Maquina ");
            //tResultado.GetComponent<Text>().text = "Jogador Empatou com a Máquina";
        }

        if ((iMaquina == 2) && (iJogador == 3))
        {
            //Debug.Log(" Jogador ganhou da Maquina ");
            //tResultado.GetComponent<Text>().text = "Jogador ganhou da Máquina";
            iPontosJogador += 1;
        }

        //Verificando resultados da Maquina para a Tesoura(3).
        if ((iMaquina == 3) && (iJogador == 1))
        {
            //Debug.Log(" Jogador ganhou da Maquina ");
            //tResultado.GetComponent<Text>().text = "Jogador ganhou da Máquina";
            iPontosJogador += 1;
        }

        if ((iMaquina == 3) && (iJogador == 2))
        {
            //Debug.Log(" Maquina ganhou do jogador ");
            //tResultado.GetComponent<Text>().text = "Máquina ganhou do jogador";
            iPontosMaquina += 1;
        }

        if ((iMaquina == 3) && (iJogador == 3))
        {
            //Debug.Log(" Jogador Empatou com a Maquina ");
            //tResultado.GetComponent<Text>().text = "Jogador Empatou com a Máquina";
        }

        //Abaixo verifica qual foi o objeto que a Maquina escolheu.
        if (iMaquina == 1)
        {
            tJogadaDaMaquina.GetComponent<Text>().text = "Máquina escolheu Pedra";
        }

        if (iMaquina == 2)
        {
            tJogadaDaMaquina.GetComponent<Text>().text = "Máquina escolheu Papel";
        }

        if (iMaquina == 3)
        {
            tJogadaDaMaquina.GetComponent<Text>().text = "Máquina escolheu Tesoura";
        }

        //=================================================================================</>

        //Verificando se Terminou o Round e Jogador ganhou.
        if ((iNumeroDeJogadas == 0) && (iPontosJogador > iPontosMaquina))
        {
            //Debug.Log("Acabou o Round e Jogador Ganhou");
            tResultado.GetComponent<Text>().text = "Acabou o Round e Jogador Ganhou";

            DestroyObject(goPedra);
            DestroyObject(goPapel);
            DestroyObject(goTesoura);
        }
        //Verificando se Terminou o Round e Maquina ganhou.
        if ((iNumeroDeJogadas == 0) && (iPontosMaquina > iPontosJogador))
        {
            //Debug.Log("Acabou o Round e Maquina Ganhou");
            tResultado.GetComponent<Text>().text = "Acabou o Round e Maquina Ganhou";

            DestroyObject(goPedra);
            DestroyObject(goPapel);
            DestroyObject(goTesoura);
        }
        ////Verificando se Terminou o Round e Maquina empatou com Jogador.
        if ((iNumeroDeJogadas == 0) && (iPontosJogador == iPontosMaquina))
        {
            //Debug.Log("Acabou o Round e Maquina empatou com Jogador");
            tResultado.GetComponent<Text>().text = "Acabou o Round e Maquina empatou com Jogador";

            DestroyObject(goPedra);
            DestroyObject(goPapel);
            DestroyObject(goTesoura);
        }

    }

    // Metodo onde jogador escolhe o objeto Pedra e acontece o resultado.
    public void Pedra()
    {
        iJogador = 1;
        iNumeroDeJogadas -= 1;
        Maquina();
        
    }
    // Metodo onde jogador escolhe o objeto Papel e acontece o resultado.
    public void Papel()
    {
        iJogador = 2;
        iNumeroDeJogadas -= 1;
        Maquina();
    }
    // Metodo onde jogador escolhe o objeto Tesoura e acontece o resultado.
    public void Tesoura()
    {
        iJogador = 3;
        iNumeroDeJogadas -= 1;
        Maquina();
    }

    public void Sair()
    {
        Application.Quit();
    }

}
