//using Facebook.Unity;
//using UnityEngine;
//using UnityEngine.UI;
//using System.Collections.Generic;

//public class FacebookManager : MonoBehaviour
//{

//    public Text userIdText;

//    private void Awake()
//    {
//        if (!FB.IsInitialized)
//        {
//            FB.Init();
//        }
//        else
//        {
//            FB.ActivateApp();
//        }
//    }

//    public void LogIn()
//    {
//        FB.LogInWithReadPermissions(callback: OnLogIn);
//    }

//    private void OnLogIn(ILoginResult result)
//    {
//        if (FB.IsLoggedIn)
//        {
//            AccessToken token = AccessToken.CurrentAccessToken;
            
//        }
//        else
//            Debug.Log("Canceled Login");
//    }

//    public void Share()
//    {
//        FB.ShareLink(
//            contentTitle: "HH Page message",
//            contentURL: new System.Uri("https://developers.facebook.com/apps/420271338397050"),
//            contentDescription: "I made" + userIdText + "points on Horizon Hill",
//            callback: OnShare);
//    }

//    private void OnShare(IShareResult result)
//    {
//        if (result.Cancelled || !string.IsNullOrEmpty(result.Error))
//        {
//            Debug.Log("ShareLink error:" + result.Error);


//        }
//        else if (!string.IsNullOrEmpty(result.PostId))
//        {
//            Debug.Log(result.PostId);
//        }
//        else
//            Debug.Log("Share succed");
//    }
//}

