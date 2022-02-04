using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // sahne yükleme kütüphanesi
using UnityEngine.UI;

public class menü : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene(1); // 1. sahneyi başlatma
    }

    public void RePlayButton()
    {
        Time.timeScale = 1; // oyunu devam ettirir. (emin olmak için)
        SceneManager.LoadScene(1); // (1'i) oyun sahnesini yeniden yükler.
    }

    public void ReturnMenu()
    {
        SceneManager.LoadScene(0); // (0'ı) menü sahnesini yeniden yükler.
    }

    public void QuitButton()
    {
        Application.Quit(); // oyunu kapatma fonksiyonu
    }
}