using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dialogo : MonoBehaviour
{
    public Text         sSourceDialogueText1;
    public Text         sSourceDialogueText2;
    public GameObject   goPhotoMainCharacter;
    public GameObject   goPhotoCharacterSecondary;
    public GameObject   imgBackgroundText1;
    public GameObject   imgBackgroundText2;
    public bool         bCheckingSpeaks;
    public GameObject   goDialogChar1;
    public GameObject   goDialogChar2;
    public string[]     sSpeaks;
    private int         iNextSpeaks;

    //Opcional a Void Start
    //
    void Start()
    {
        if (bCheckingSpeaks == true)
        {
            Debug.Log("Fala");
        }
        else
        {
            Debug.Log("Dialogo");
        }

    }

    void Update()
    {
        //Verificando se é um dialogo ou uma fala.
        //
        if ( bCheckingSpeaks == true )
        {
            //Fala ativada, desativando personagem secundario.
            //
            goDialogChar2.SetActive(false);
            goDialogChar1.SetActive(true);
            sSourceDialogueText1.GetComponent<Text>().text = sSpeaks[iNextSpeaks].ToString();
        }
        else
        {
            //Dialogo ativado, chamando metodo.
            //
            ManagingDialogues();
        }

    }

    //Gerenciando os dialogos.
    public void ManagingDialogues()
    {
        //Personagem secundario começando o dialogo e verificando quem esta falando.
        //
        if ( (iNextSpeaks % 2 ) == 0 )
        {
            goDialogChar1.SetActive(false);
            goDialogChar2.SetActive(true);
            sSourceDialogueText2.GetComponent<Text>().text = sSpeaks[iNextSpeaks].ToString();
        }
        else
        {
            goDialogChar2.SetActive(false);
            goDialogChar1.SetActive(true);
            sSourceDialogueText1.GetComponent<Text>().text = sSpeaks[iNextSpeaks].ToString();
        }

    }

    public void BtnNext(int iNivel)
    {
        iNextSpeaks++;
        //Verificando se as falas acabou.
        //
        if( iNextSpeaks == sSpeaks.Length )
        {
            SceneManager.LoadScene(iNivel);
            goDialogChar1.SetActive(false);
            goDialogChar2.SetActive(false);
            
        }
    }

}

