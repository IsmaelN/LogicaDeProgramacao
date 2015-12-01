using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class teste : MonoBehaviour
{
	private int 	iNumero;
	public Button 	btn;
	public Text 	tSaida;

	//0 = Desliga.
	//1 = Ligada.

	void Start()
	{
		//Valor inicial da variavel(Ligada).
		iNumero = 1;
	}

	void Update()
	{
		Debug.Log (iNumero);
	}

	public void LigarDesliga()
	{
		//Valor da variavel(deligada).
		iNumero--;

		//Trocando valor da variavel( iNumero ).
		if (iNumero < 0)
		{
			iNumero = iNumero + 2;
		}

		Verificando ();
	}

	public void Verificando()
	{
		if( iNumero == 1 )
		{
			tSaida.GetComponent<Text>().text = "Ligado";
		}

		if( iNumero == 0 )
		{
			tSaida.GetComponent<Text>().text = "Desligado";
		}

	}

}
