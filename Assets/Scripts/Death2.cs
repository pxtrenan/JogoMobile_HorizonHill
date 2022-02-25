using UnityEngine;
//using UnityEngine.Advertisements;


public class Death2 : MonoBehaviour
{
    public static bool isGameOver;
    private int deadCount;
    public GameObject gameOver;
    public GameObject pontuacao;
   
//    private RewardBasedVideoAd rewardBasedVideo;

//    public void ShowInterstitialAd()
//    {
//        //Show Ad
//        if (interstitial.IsLoaded())
//        {
//            interstitial.Show();

//            //Stop Sound
//            //

//            Debug.Log("SHOW AD XXX");
//        }
//    }

//    void Start()
//    {
//        RequestInterstitialAds();
//        deadCount = 0;
       

//    }

//    InterstitialAd interstitial;
//    private void RequestInterstitialAds()
//    {
//        string adID = "ca-app-pub-1911725355586876/4773905991";

//#if UNITY_ANDROID
//        string adUnitId = adID;
//#elif UNITY_IOS
//        string adUnitId = adID;
//#else
//        string adUnitId = adID;
//#endif

//        // Initialize an InterstitialAd.
//        interstitial = new InterstitialAd(adUnitId);

//        //***Test***
//        AdRequest request = new AdRequest.Builder()
//       .AddTestDevice(AdRequest.TestDeviceSimulator)       // Simulator.
//       .AddTestDevice("2077ef9a63d2b398840261c8221a0c9b")  // My test device.
//       .Build();

//        //***Production***
//        //AdRequest request = new AdRequest.Builder().Build();

//        //Register Ad Close Event
//        interstitial.OnAdClosed += Interstitial_OnAdClosed;

//        // Load the interstitial with the request.
//        interstitial.LoadAd(request);

//        Debug.Log("AD LOADED XXX");

//    }
//    //Ad Close Event
//    private void Interstitial_OnAdClosed(object sender, System.EventArgs e)
//    {
//        //Resume Play Sound

//    }

    public void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
                if (deadCount == 0)
                {
            //if (Advertisement.IsReady("video"))
            //{
            //    Advertisement.Show("video");
            //}
            deadCount += 1;
                }
                // We reset counter after 3 deads
                else if (deadCount == 3)
                {
                    deadCount = 0;
                }
                isGameOver = true;
                Destroy(other.gameObject);
                gameOver.gameObject.SetActive(true);
                pontuacao.gameObject.SetActive(false);
            

        }
    }


