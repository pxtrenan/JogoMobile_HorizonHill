//using UnityEngine;
//using UnityEngine.SceneManagement;
//using UnityEngine.Advertisements;
//using UnityEngine.UI;
//using GoogleMobileAds.Api;

//public class Revive : MonoBehaviour {

//    public Image hudRed;
//    public GameObject revive;
//    public GameObject gameOver;
//    public GameObject pontuacao;
//    public GameObject text1;
//    public GameObject text2;

    
//    public GameObject player2;
//    public GameObject player3;

//    public GameObject videoRevive;
//    public GameObject playRevive;

//    public GameObject hud;
//    public GameObject hud1;
//    public GameObject hudback;
//    private RewardBasedVideoAd rewardBasedVideo;

//    public string placementId = "rewardedVideo";

//    private int cena;
//    private int temp = 0;
   
//    private float totalTime = 0.5f;
//    private float currentTime;
//    private bool isGameOver;

//    private Death dt;

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

//    // Use this for initialization
//    void Start() {
//        RequestInterstitialAds();
//        currentTime = totalTime;
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

//    // Update is called once per frame
//    void Update() {
        
//        if(isGameOver) return;

//        currentTime -= Time.deltaTime;
//        SetHud(currentTime / totalTime);

//        if(currentTime <= -4.7)
//        {

//            ShowInterstitialAd();

//            isGameOver = true;
//            revive.gameObject.SetActive(false);
//            gameOver.gameObject.SetActive(true);
//            pontuacao.gameObject.SetActive(false);
//        }

//    }


//    public void ShowVideoRevive()
//    {
        
//       isGameOver = true;

//        RequestReward();
//        videoRevive.gameObject.SetActive(false);
//        hud.gameObject.SetActive(false);
//        hud1.gameObject.SetActive(false);
//        hudback.gameObject.SetActive(false);
       
//        if (rewardBasedVideo.IsLoaded())
//        {
//            rewardBasedVideo.Show();
//        }

//    }

        
//    void RequestReward()
//    {
//        string adID = "ca-app-pub-1911725355586876/4291042880";

//#if UNITY_ANDROID
//        string adUnitId = adID;
//#elif UNITY_IOS
//        string adUnitId = adID;
//#else
//        string adUnitId = adID;
//#endif

//        rewardBasedVideo = RewardBasedVideoAd.Instance;

//        ShowOptions options = new ShowOptions();
//        options.resultCallback = HandleShowResult;

//        Advertisement.Show(placementId, options);
//    }

//    void ShowReward()
//    {
//        if (rewardBasedVideo.IsLoaded())
//        {
//            rewardBasedVideo.Show();
//        }
//    }
//    void HandleShowResult(ShowResult result)
//    {
//        if (result == ShowResult.Finished)
//        {
//            Debug.Log("Video completed - Offer a reward to the player");
//            player3.gameObject.SetActive(true);
//            playRevive.gameObject.SetActive(true);
//            text1.gameObject.SetActive(false);
//            text2.gameObject.SetActive(true);
            
            

           
//        }
//        else if (result == ShowResult.Skipped)
//        {
//            Debug.LogWarning("Video was skipped - Do NOT reward the player");
//            revive.gameObject.SetActive(false);
//            pontuacao.gameObject.SetActive(false);
//            gameOver.gameObject.SetActive(true);

//        }
//        else if (result == ShowResult.Failed)
//        {
//            Debug.LogError("Video failed to show");
//            pontuacao.gameObject.SetActive(false);
//            revive.gameObject.SetActive(false);
//            gameOver.gameObject.SetActive(true);

//        }


//    }

//        public void PlayReviveButton()
//        {
//        player3.gameObject.SetActive(false);
//        player2.gameObject.SetActive(true);
//        revive.gameObject.SetActive(false);
        
//        //cena = Random.Range(1, 8);
//        //Debug.Log(cena);

//        //while (temp == cena)
//        //{
//        //    DontDestroyOnLoad(pontuacao.transform.gameObject);
//        //    cena = Random.Range(1, 8);
//        //}

//        //temp = cena;

//        //switch (cena)
//        //{
            
//        //    case 1:
//        //        SceneManager.LoadScene("Second2EN");
//        //        break;
//        //    case 2:
//        //        SceneManager.LoadScene("Second3EN");
//        //        break;
//        //    case 3:
//        //        SceneManager.LoadScene("Second4EN");
//        //        break;
//        //    case 4:
//        //        SceneManager.LoadScene("Second5EN");
//        //        break;
//        //    case 5:
//        //        SceneManager.LoadScene("Second6EN");
//        //        break;
//        //    case 6:
//        //        SceneManager.LoadScene("Second7EN");
//        //        break;
//        //    case 7:
//        //        SceneManager.LoadScene("Second8EN");
//        //        break;

        


//    }

//    public void SetHud(float value)
//    {
//        float total = 10f;
//        float pos = total - (value * total);
//        hudRed.transform.localPosition = new Vector3(-pos, hudRed.transform.localPosition.y, hudRed.transform.localPosition.z);

//    }
//}

    

