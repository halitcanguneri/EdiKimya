using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using GoogleMobileAds.Common;
using System;

public class ADmobReklam : MonoBehaviour
{
    private RewardedAd odulluReklam;
    public GameObject DeathScreen;
    
    void Start()
    {
        string adUnitId;
#if UNITY_ANDROID
        adUnitId = "ca-app-pub-2471105127721777/4098671967"; // EdiKimya Ödüllü reklam orjinal kendi reklam kodum.
#elif UNITY_IPHONE  
adUnitId = "ca-app-pub-3940256099942544/1712485313";
#else
adUnitId = "unexpected_platform";
#endif

        this.odulluReklam = new RewardedAd(adUnitId);//
        this.odulluReklam.OnUserEarnedReward += OyuncuyaOduluVer;//

    }

   

    public void reklamizle()
    {
        AdRequest request = new AdRequest.Builder().Build();
        this.odulluReklam.LoadAd(request);


        if (this.odulluReklam.IsLoaded())
        {
            this.odulluReklam.Show();
        }
    }
    public void Resume()                                  //reklam gelecek ondan sonra basýlabilecek.
    {
        Time.timeScale = 1;
        DeathScreen.SetActive(false);

    }

    private void OyuncuyaOduluVer(object sender, Reward e)
    {
        Resume();

    }
}
