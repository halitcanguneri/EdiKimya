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






    //etkile�imler alan�
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "yesilBeherglas(Clone)")//zarars�z
        {
            managerGame.ScoreArtt�r();
            Debug.Log(score);
            //ses dosyalar�n� buraya at.
        }
        if (collision.gameObject.name == "k�rm�z�Beherglas Variant(Clone)")//zararl�
        {
            managerGame.ScoreAzalt();
            Debug.Log(score);
        }
        if (collision.gameObject.name == "Tuz(Clone)")//zarars�z
        {
            managerGame.ScoreArtt�r();

        }
        if (collision.gameObject.name == "Amonyak(Clone)")//zararl�
        {
            managerGame.ScoreAzalt();
        }
        if (collision.gameObject.name == "Asetik-asit(Clone)")//zararl�
        {
            managerGame.ScoreAzalt();
        }
        if (collision.gameObject.name == "Glukoz(Clone)")//zarars�z
        {
            managerGame.ScoreArtt�r();

        }
        if (collision.gameObject.name == "Hidrojen-klor�r(Clone)")//zararl�
        {
            managerGame.ScoreAzalt();
        }
        if (collision.gameObject.name == "Kalsiyum-hidroksit(Clone)")//zararl�
        {
            managerGame.ScoreAzalt();
        }
        if (collision.gameObject.name == "Kalsiyum-karbonat(Clone)")//zarars�z
        {
            managerGame.ScoreArtt�r();
        }
        if (collision.gameObject.name == "Karbondioksit(Clone)")//zarars�z
        {
            managerGame.ScoreArtt�r();
        }
        if (collision.gameObject.name == "K�k�rt-dioksit(Clone)")//Zararl�
        {
            managerGame.ScoreAzalt();
        }
        if (collision.gameObject.name == "Potasyum-nitrat(Clone)")//Zarars�z
        {
            managerGame.ScoreArtt�r();
        }
        if (collision.gameObject.name == "Potasyum-permanganat(Clone)")//zararl�
        {
            managerGame.ScoreAzalt();
        }
        if (collision.gameObject.name == "Sodyum-bikarbonat(Clone)")//zarars�z
        {
            managerGame.ScoreArtt�r();
        }
        if (collision.gameObject.name == "Su(Clone)")//zarars�z
        {
            managerGame.ScoreArtt�r();

        }
        if (collision.gameObject.name == "S�lf�rik-asit(Clone)")//zararl�
        {
            managerGame.ScoreAzalt();
        }
        if (collision.gameObject.name == "Metan(Clone)")//zararl�
        {
            managerGame.ScoreAzalt();
        }


    }
}
