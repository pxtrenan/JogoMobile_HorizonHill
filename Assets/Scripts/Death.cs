using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;
using GoogleMobileAds.Api;

public class Death : MonoBehaviour
{
    public static bool isGameOver;
    private int deadCount;
    public float currentTime;
    public GameObject gameOver;
    public GameObject pontuacao;
     private RewardBasedVideoAd rewardBasedVideo;
    public Button m_Button;
    public GameObject spawn;
    public GameObject reviveButton;
    public GameObject player;
    public GameObject player2;
    public string placementId = "rewardedVideo";

    public void ShowInterstitialAd()
    {
        //Show Ad
        if (interstitial.IsLoaded())
        {
            interstitial.Show();

            //Stop Sound
            //

            Debug.Log("SHOW AD XXX");
        }
    }

    void Start()
    {
        RequestInterstitialAds();

        deadCount = 0;
        currentTime = 0;


    }



    InterstitialAd interstitial;
    private void RequestInterstitialAds()
    {
        string adID = "ca-app-pub-2689440637834639/2981419230";

#if UNITY_ANDROID
        string adUnitId = adID;
#elif UNITY_IOS
        string adUnitId = adID;
#else
        string adUnitId = adID;
#endif

        // Initialize an InterstitialAd.
        interstitial = new InterstitialAd(adUnitId);

        //***Test***
        AdRequest request = new AdRequest.Builder()
       .AddTestDevice(AdRequest.TestDeviceSimulator)       // Simulator.
       .AddTestDevice("2077ef9a63d2b398840261c8221a0c9b")  // My test device.
       .Build();

        //***Production***
        //AdRequest request = new AdRequest.Builder().Build();

        //Register Ad Close Event
        interstitial.OnAdClosed += Interstitial_OnAdClosed;

        // Load the interstitial with the request.
        interstitial.LoadAd(request);

        Debug.Log("AD LOADED XXX");

    }
    //Ad Close Event
    private void Interstitial_OnAdClosed(object sender, System.EventArgs e)
    {
        //Resume Play Sound

    }

    public void Update()
    {
        currentTime += Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        currentTime += Time.deltaTime;

        if (other.tag == "Player")
        {

            if (currentTime > 35)
            {
                isGameOver = true;

                player.gameObject.SetActive(false);
            
            }


            if (deadCount == 0)
            {
                ShowInterstitialAd();
                deadCount += 1;
            }
           // We reset counter after 3 deads
                else if (deadCount == 3)
            {
                deadCount = 0;
            }
            isGameOver = true;
            player2.gameObject.SetActive(false);

            player.gameObject.SetActive(false);
            gameOver.gameObject.SetActive(true);
            pontuacao.gameObject.SetActive(false);



            //if (other.tag == "Player2")
            //{

            //    {
            //        //if (deadCount == 0)
            //        //    if (Advertisement.IsReady("video"))
            //        //    {
            //        //        Advertisement.Show("video");
            //        //    }
            //        deadCount += 1;
            //    }
            //    // We reset counter after 3 deads
            //    else if (deadCount == 3)
            //    {
            //        deadCount = 0;
            //    }
            //    isGameOver = true;
            //    player2.gameObject.SetActive(false);

            //    gameOver.gameObject.SetActive(true);
            //    pontuacao.gameObject.SetActive(false);
            //}

        }
    }
}

	