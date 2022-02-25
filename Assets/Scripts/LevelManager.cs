using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GoogleMobileAds.Api;



public class LevelManager : MonoBehaviour
{

    public static LevelManager levelManager;


    public GameObject New;
    private RewardBasedVideoAd rewardBasedVideo;
    private int coinsAtual = 0;

    public Text coinsT;
    public Text coinsT2;
    public Text highScore;

    public AudioClip soundCrystalBlue;
    public AudioClip soundCoin;
    public AudioSource somPlayer;
    public AudioSource somPlayer2;

    // Use this for initialization
    void Awake()
    {
        somPlayer.ignoreListenerPause = true;

        if (levelManager == null)
        {
            levelManager = this;
        }
        else if (levelManager != this)
        {

            Destroy(gameObject);

        }
        
    }

        
        
    

    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {


    }
    public void SetCoins()
    {
        coinsAtual++;
        coinsT.text = coinsAtual.ToString();
        coinsT2.text = coinsAtual.ToString();
        somPlayer.PlayOneShot(soundCoin);
        somPlayer2.PlayOneShot(soundCoin);

        if (coinsAtual > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", coinsAtual);
            New.gameObject.SetActive(true);
        }

    }
    public int GetCoins()
    {
        return coinsAtual;
    }

    public void SetCrystais()
    {
        coinsAtual += 5;
        coinsT.text = coinsAtual.ToString();
        coinsT2.text = coinsAtual.ToString();

        somPlayer.PlayOneShot(soundCoin);
        somPlayer2.PlayOneShot(soundCoin);

        if (coinsAtual > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", coinsAtual);
            New.gameObject.SetActive(true);
        }

    }
    public int GetCrystais()
    {
        return coinsAtual;
    }
    public void SetBlueCrystais()
    {
        coinsAtual += 50;
        coinsT.text = coinsAtual.ToString();
        coinsT2.text = coinsAtual.ToString();
        somPlayer.PlayOneShot(soundCrystalBlue);
        somPlayer2.PlayOneShot(soundCrystalBlue);

        if (coinsAtual > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", coinsAtual);
            New.gameObject.SetActive(true);

        }
        
    }
    public int GetBlueCrystais()
    {
        return coinsAtual;
    }

    public void SetOrangeCrystal()
    {
        coinsAtual += 300;
        coinsT.text = coinsAtual.ToString();
        coinsT2.text = coinsAtual.ToString();

        somPlayer.PlayOneShot(soundCrystalBlue);
        somPlayer2.PlayOneShot(soundCrystalBlue);

        if (coinsAtual > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", coinsAtual);
            New.gameObject.SetActive(true);

        }
                
    }
    public int GetOrangeCrystal()
    {
        return coinsAtual;
    }

//    private void RequestRewardBasedVideo()
//    {
//#if UNITY_ANDROID
//        string adUnitId = "ca-app-pub-5393041149880030~6283126266";
//#elif UNITY_IPHONE
//            string adUnitId = "ca-app-pub-3940256099942544/1712485313";
//#else
//            string adUnitId = "unexpected_platform";
//#endif

//        // Create an empty ad request.
//        AdRequest request = new AdRequest.Builder().Build();
//        // Load the rewarded video ad with the request.
//        this.rewardBasedVideo.LoadAd(request, adUnitId);
//    }


}