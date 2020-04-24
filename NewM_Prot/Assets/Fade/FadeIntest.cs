using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeIntest : MonoBehaviour
{

    public Fade fade;       //FadeCanvas取得
    manager script;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (script.ClearNum<=8)
        {
            fadestart();
        }
       
    }

    public void fadestart()
    {
        //アニメーションを掛けてシーン遷移する
        fade.FadeIn(1f, () =>
        {
            SceneManager.LoadScene("EASY");
        });
    }
}
