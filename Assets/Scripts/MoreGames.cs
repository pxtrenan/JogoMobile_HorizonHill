using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreGames : MonoBehaviour {

    public string ANDROID_RATE_URL = "market://details?id=com.ra.HorizonHill";
    public string ANDROID_OTHER_URL = "market://details?id=com.ra.StarScraper";
    public string ANDROID_OTHER_URL2 = "market://details?id=com.ra.MVPChallenge";
    public string ANDROID_OTHER_URL3 = "market://details?id=com.Turned.tn";

    public void PressedButtonOther()
    {
#if UNITY_ANDROID
        Application.OpenURL(ANDROID_OTHER_URL);
        Debug.Log("Rate on Android");
#elif UNITY_IOS
        Application.OpenURL(IOS_RATE_URL);
                Debug.Log("Rate on Iphone");
#endif
    }

    public void PressedButtonOther2()
    {
#if UNITY_ANDROID
        Application.OpenURL(ANDROID_OTHER_URL2);
        Debug.Log("Rate on Android");
#elif UNITY_IOS
        Application.OpenURL(IOS_RATE_URL);
                Debug.Log("Rate on Iphone");
#endif
    }
    public void PressedButtonRate()
    {
#if UNITY_ANDROID
        Application.OpenURL(ANDROID_RATE_URL);
        Debug.Log("Rate on Android");
#elif UNITY_IOS
        Application.OpenURL(IOS_RATE_URL);
                Debug.Log("Rate on Iphone");
#endif
    }

    public void PressedButtonOther3()
    {
#if UNITY_ANDROID
        Application.OpenURL(ANDROID_OTHER_URL3);
        Debug.Log("Rate on Android");
#elif UNITY_IOS
        Application.OpenURL(IOS_RATE_URL);
                Debug.Log("Rate on Iphone");
#endif
    }
}
