using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class edi : MonoBehaviour
{
    
    public int score=0;
    public GameManager managerGame;

    private void Start()
    {
        Time.timeScale = 1;
        
    }






    //etkileþimler alaný
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "yesilBeherglas(Clone)")//zararsýz
        {
            managerGame.ScoreArttýr();
            Debug.Log(score);
            //ses dosyalarýný buraya at.
        }
        if (collision.gameObject.name == "kýrmýzýBeherglas Variant(Clone)")//zararlý
        {
            managerGame.ScoreAzalt();
            Debug.Log(score);
        }
        if (collision.gameObject.name == "Tuz(Clone)")//zararsýz
        {
            managerGame.ScoreArttýr();

        }
        if (collision.gameObject.name == "Amonyak(Clone)")//zararlý
        {
            managerGame.ScoreAzalt();
        }
        if (collision.gameObject.name == "Asetik-asit(Clone)")//zararlý
        {
            managerGame.ScoreAzalt();
        }
        if (collision.gameObject.name == "Glukoz(Clone)")//zararsýz
        {
            managerGame.ScoreArttýr();

        }
        if (collision.gameObject.name == "Hidrojen-klorür(Clone)")//zararlý
        {
            managerGame.ScoreAzalt();
        }
        if (collision.gameObject.name == "Kalsiyum-hidroksit(Clone)")//zararlý
        {
            managerGame.ScoreAzalt();
        }
        if (collision.gameObject.name == "Kalsiyum-karbonat(Clone)")//zararsýz
        {
            managerGame.ScoreArttýr();
        }
        if (collision.gameObject.name == "Karbondioksit(Clone)")//zararsýz
        {
            managerGame.ScoreArttýr();
        }
        if (collision.gameObject.name == "Kükürt-dioksit(Clone)")//Zararlý
        {
            managerGame.ScoreAzalt();
        }
        if (collision.gameObject.name == "Potasyum-nitrat(Clone)")//Zararsýz
        {
            managerGame.ScoreArttýr();
        }
        if (collision.gameObject.name == "Potasyum-permanganat(Clone)")//zararlý
        {
            managerGame.ScoreAzalt();
        }
        if (collision.gameObject.name == "Sodyum-bikarbonat(Clone)")//zararsýz
        {
            managerGame.ScoreArttýr();
        }
        if (collision.gameObject.name == "Su(Clone)")//zararsýz
        {
            managerGame.ScoreArttýr();

        }
        if (collision.gameObject.name == "Sülfürik-asit(Clone)")//zararlý
        {
            managerGame.ScoreAzalt();
        }
        if (collision.gameObject.name == "Metan(Clone)")//zararlý
        {
            managerGame.ScoreAzalt();
        }


    }
}
