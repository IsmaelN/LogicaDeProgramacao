using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class teste : MonoBehaviour
{
	private int 		iNumero;
	public 	Button 		btn;
	public 	Text 		tSaida;
	public 	AudioSource	musicaDeFundo;
	//0 = Desliga <> 1 = Ligada.


	void Start()
	{
		//Valor inicial da variavel(Ligada).
		iNumero = 0;
	}

	void Update()
	{
		Verificando ();
		Debug.Log (iNumero);
	}

	public void LigarDesliga()
	{
		//Valor da variavel(deligada).
		PlayerPrefs.GetInt("efeitosSonoros");
		iNumero--;

		//Trocando valor da variavel( iNumero ).
		if (iNumero < 0)
		{
			iNumero = iNumero + 2;
		}
		//Salvando a escolha do usuario.
		PlayerPrefs.SetInt ("efeitosSonoros", iNumero);
	}

	public void Verificando()
	{
		if( iNumero == 1 )
		{
			//Ligando musica da cena qualquer.
			musicaDeFundo.enabled = true;
			tSaida.GetComponent<Text>().text = "Ligado";
		}

		if( iNumero == 0 )
		{
			//Desligando musica da cena qualquer.
			musicaDeFundo.enabled = false;
			tSaida.GetComponent<Text>().text = "Desligado";
		}

	}
	
}
