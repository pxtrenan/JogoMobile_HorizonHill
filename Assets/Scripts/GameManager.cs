using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public PlayerController pl;
    public LevelManager lm;

    public GameObject icones;
    public GameObject playButton;
    public GameObject settings;
    public GameObject botao;
    public GameObject musicOFF;
    public GameObject musicON;
    public GameObject shop;
    public GameObject rank;
    public GameObject otherGame;
    //public GameObject hud;
    //public GameObject hud1;
    //public GameObject hudback;

    //public GameObject videoRevive;
    //public GameObject playRevive;


    private int temp = 0;

    public AudioSource som;


    
    public string IOS_RATE_URL = "itms-apps://itunes.apple.com/app/id=com.ra.HorizonHill";

    public string TWITTER_ADDRES = "http://twitter.com/intent/tweet";
    public string TWEET_LANGUAGE = "en";


    private int cena;


  

    public void Mute()
    {
        AudioListener.pause = !AudioListener.pause;
    }

    public void CarregaCena(string nomeCena)
    {

        {
            SceneManager.LoadScene(nomeCena);
        }
    }

    public void CarregarLevelEN(string nomeLevel)
    {

        cena = Random.Range(1, 8);
        Debug.Log(cena);

        while (temp == cena)
        {
            cena = Random.Range(1, 8);
        }

        temp = cena;

        switch (cena)
        {
            case 1:
                SceneManager.LoadScene("jogo8EN");
                break;
            case 2:
                SceneManager.LoadScene("jogo2EN");
                break;
            case 3:
                SceneManager.LoadScene("jogo3EN");
                break;
            case 4:
                SceneManager.LoadScene("jogo4EN");
                break;
            case 5:
                SceneManager.LoadScene("jogo5EN");
                break;
            case 6:
                SceneManager.LoadScene("jogo6EN");
                break;
            case 7:
                SceneManager.LoadScene("jogo7EN");
                break;

        }
    }

    public void Settings()
    {
        icones.gameObject.SetActive(false);
        playButton.gameObject.SetActive(false);
        settings.gameObject.SetActive(true);
        botao.gameObject.SetActive(false);
        shop.gameObject.SetActive(false);
        rank.gameObject.SetActive(false);

    }
    public void Other()
    {
        icones.gameObject.SetActive(false);
        playButton.gameObject.SetActive(false);
        otherGame.gameObject.SetActive(true);
        botao.gameObject.SetActive(false);
        shop.gameObject.SetActive(false);
        rank.gameObject.SetActive(false);

    }

    public void Quit()
    {
        Application.Quit();
    }
    public void Voltar()
    {
        icones.gameObject.SetActive(true);
        playButton.gameObject.SetActive(true);
        settings.gameObject.SetActive(false);
        botao.gameObject.SetActive(true);
        shop.gameObject.SetActive(true);
        rank.gameObject.SetActive(true);

    }
    public void Voltar2()
    {
        icones.gameObject.SetActive(true);
        playButton.gameObject.SetActive(true);
        otherGame.gameObject.SetActive(false);
        botao.gameObject.SetActive(true);
        shop.gameObject.SetActive(true);
        rank.gameObject.SetActive(true);

    }

    public void MusicOFF()
    {
        AudioListener.pause = true;
        if (AudioListener.pause)
        {
            musicOFF.gameObject.SetActive(false);
            musicON.gameObject.SetActive(true);

            DontDestroyOnLoad(gameObject);
        }
    }
    public void MusicON()
    {

        AudioListener.pause = false;
        musicOFF.gameObject.SetActive(true);
        musicON.gameObject.SetActive(false);
    }



  

    //public void ShowVideoRevive()
    //{
    //    videoRevive.gameObject.SetActive(false);
    //    playRevive.gameObject.SetActive(true);
    //    hud.gameObject.SetActive(false);
    //    hud1.gameObject.SetActive(false);
    //    hudback.gameObject.SetActive(false);
    //}

    //public void PlayReviveButton()
    //{

    //    cena = Random.Range(1, 8);
    //    Debug.Log(cena);

    //    while (temp == cena)
    //    {
    //        cena = Random.Range(1, 8);
    //    }

    //    temp = cena;

    //    switch (cena)
    //    {
    //        case 1:
    //            SceneManager.LoadScene("Second2EN");
    //            break;
    //        case 2:
    //            SceneManager.LoadScene("Second3EN");
    //            break;
    //        case 3:
    //            SceneManager.LoadScene("Second4EN");
    //            break;
    //        case 4:
    //            SceneManager.LoadScene("Second5EN");
    //            break;
    //        case 5:
    //            SceneManager.LoadScene("Second6EN");
    //            break;
    //        case 6:
    //            SceneManager.LoadScene("Second7EN");
    //            break;
    //        case 7:
    //            SceneManager.LoadScene("Second8EN");
    //            break;

    //    }


    //}
}

    
