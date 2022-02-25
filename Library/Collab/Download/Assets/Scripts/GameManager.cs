using System.Collections;
using System.Collections.Generic;
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
	public GameObject language;

	public AudioSource som;
    

	public string ANDROID_RATE_URL = "market://details?id=com.hh.HorizonHill";
	public string IOS_RATE_URL = "itms-apps://itunes.apple.com/app/id=com.hh.HorizonHill";

	public string TWITTER_ADDRES = "http://twitter.com/intent/tweet";
	public string TWEET_LANGUAGE = "en";

   
	private int cena;

    
    

	
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public void Mute ()
	{
		AudioListener.pause = !AudioListener.pause; 
	}

	public void CarregaCena (string nomeCena)
	{
		SceneManager.LoadScene (nomeCena);
	}

	public void CarregarLevelEN (string nomeLevel)
	{
		cena = Random.Range (1, 9);
		Debug.Log (cena);


		switch (cena) {
		case 1:
			SceneManager.LoadScene ("jogoEN");
			break;
		case 2:
			SceneManager.LoadScene ("jogo2EN");
			break;
		case 3:
			SceneManager.LoadScene ("jogo3EN");
			break;
		case 4:
			SceneManager.LoadScene ("jogo4EN");
			break;
		case 5:
			SceneManager.LoadScene ("jogo5EN");
			break;
		case 6:
			SceneManager.LoadScene ("jogo6EN");
			break;
		case 7:
			SceneManager.LoadScene ("jogo7EN");
			break;
		case 8:
			SceneManager.LoadScene ("jogo8EN");
			break;
		}

	}

	public void CarregarLevelPT (string nomeLevel)
	{
		cena = Random.Range (1, 9);
		Debug.Log (cena);


		switch (cena) {
		case 1:
			SceneManager.LoadScene ("jogoPT");
			break;
		case 2:
			SceneManager.LoadScene ("jogo2PT");
			break;
		case 3:
			SceneManager.LoadScene ("jogo3PT");
			break;
		case 4:
			SceneManager.LoadScene ("jogo4PT");
			break;
		case 5:
			SceneManager.LoadScene ("jogo5PT");
			break;
		case 6:
			SceneManager.LoadScene ("jogo6PT");
			break;
		case 7:
			SceneManager.LoadScene ("jogo7PT");
			break;
		case 8:
			SceneManager.LoadScene ("jogo8PT");
			break;
		}
	}

	public void CarregaLevelES ()
	{
		cena = Random.Range (1, 9);
		Debug.Log (cena);


		switch (cena) {
		case 1:
			SceneManager.LoadScene ("jogoES");
			break;
		case 2:
			SceneManager.LoadScene ("jogo2ES");
			break;
		case 3:
			SceneManager.LoadScene ("jogo3ES");
			break;
		case 4:
			SceneManager.LoadScene ("jogo4ES");
			break;
		case 5:
			SceneManager.LoadScene ("jogo5ES");
			break;
		case 6:
			SceneManager.LoadScene ("jogo6ES");
			break;
		case 7:
			SceneManager.LoadScene ("jogo7ES");
			break;
		case 8:
			SceneManager.LoadScene ("jogo8ES");
			break;
		}

	}

	public void Settings ()
	{
		icones.gameObject.SetActive (false);
		playButton.gameObject.SetActive (false);
		settings.gameObject.SetActive (true);
		botao.gameObject.SetActive (false);
		shop.gameObject.SetActive (false);
		rank.gameObject.SetActive (false);

		DontDestroyOnLoad (musicON);

	}

	public void Voltar ()
	{
		icones.gameObject.SetActive (true);
		playButton.gameObject.SetActive (true);
		settings.gameObject.SetActive (false);
		botao.gameObject.SetActive (true);
		shop.gameObject.SetActive (true);
		rank.gameObject.SetActive (true);
	}

	public void MusicOFF ()
	{
		AudioListener.pause = true;
		musicOFF.gameObject.SetActive (false);
		musicON.gameObject.SetActive (true);
        
	}

	public void MusicON ()
	{
		AudioListener.pause = false;
		musicOFF.gameObject.SetActive (true);
		musicON.gameObject.SetActive (false);
	}

	public void Language ()
	{
		language.gameObject.SetActive (true);
		settings.gameObject.SetActive (false);
	}

	public void VoltarLanguage ()
	{
		language.gameObject.SetActive (false);
		settings.gameObject.SetActive (true);
	}

	public void Brasil ()
	{
		SceneManager.LoadScene ("menuPT");
	}

	public void Espanha ()
	{
		SceneManager.LoadScene ("menuES");
	}

	public void PressedButtonRate ()
	{
#if UNITY_ANDROID
		Application.OpenURL (ANDROID_RATE_URL);
		Debug.Log ("Rate on Android");
#elif UNITY_IOS
        Application.OpenURL(IOS_RATE_URL);
                Debug.Log("Rate on Iphone");
#endif
	}


}

    
