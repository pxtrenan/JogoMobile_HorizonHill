using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ComandosBasicos : MonoBehaviour {

    public Animator anim;
    public Image Img;

    public void CarregaCena(string nomeCena) {
        //SceneManager.LoadScene(nomeCena);
        StartCoroutine(Fade());

    }

    IEnumerator Fade()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => Img.color.a == 1); 
            SceneManager.LoadScene("jogo");

    }
}
