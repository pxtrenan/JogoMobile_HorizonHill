using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class MainScene : MonoBehaviour
{
    public Image splashImage;
    public Image splashImage2;
    public string loadLevel;

    IEnumerator Start()
    {
        splashImage.canvasRenderer.SetAlpha(0.0f);
        splashImage2.canvasRenderer.SetAlpha(0.0f);

        FadeINM();
        yield return new WaitForSeconds(2.0f);
        FadeOutM();
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene(loadLevel);
    }

    void FadeINM()
    {
        splashImage.CrossFadeAlpha(1.0f, 1.5f, false);
        splashImage2.CrossFadeAlpha(1.0f, 1.5f, false);
    }
    void FadeOutM()
    {
        splashImage.CrossFadeAlpha(0.0f, 2.0f, false);
        splashImage2.CrossFadeAlpha(0.0f, 2.0f, false);
    }
    private void Awake()
    {
        Advertisement.Initialize("1735357", true);
        Advertisement.Show();
    }



    //---------- ONLY NECESSARY FOR ASSET PACKAGE INTEGRATION: ----------//

//#if UNITY_IOS
//private string gameId = "1486551";
//#elif UNITY_ANDROID
//    private string gameId = "1735357";
//#endif
}
