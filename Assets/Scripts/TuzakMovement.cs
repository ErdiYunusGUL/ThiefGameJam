using DG.Tweening;
using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class TuzakMovement : MonoBehaviour
{
    [SerializeField] float timerDuration;
   
    void Start()
    {
        GoToSurface();
        GoUnderground();
    }

    void GoToSurface()
    {
        transform.DOMoveY(1, 1);
        Invoke(nameof(GoUnderground), 3f);
    }
    void GoUnderground()
    {
        transform.DOMoveY(-1, 1);


        // Nesneyi yerin alt�na g�nderdikten 3 saniye sonra y�zeye ��kar
        Invoke("GoToSurface", 3f);

    }
    // Update is called once per frame
    void Update()
    {
        
        
        
        
        
        //if (tuzakaltta)
        //{

        //    float newY = Mathf.Lerp(startY, endY, Time.time / duration);

        //    // Objeyi yeni y�ksekli�e ta��.
        //    transform.position = new Vector3(transform.position.x, newY, transform.position.z);
        //    tuzakaltta = false;
           
        //}

        //if (!tuzakaltta)
        //{
        //    transform.DOMoveY(-1, 1);
        //}

        ////if (!tuzakaltta)
        ////{
        ////    float oldY = Mathf.Lerp(endY, startY, Time.time / duration);

        ////    // Objeyi yeni y�ksekli�e ta��.
        ////    transform.position = new Vector3(transform.position.x, oldY, transform.position.z);
        ////}

        ////if (tuzak�stte)
        ////{
        ////    float oldY = Mathf.Lerp(endY, startY, Time.time / duration);

        ////    // Objeyi yeni y�ksekli�e ta��.
        ////    transform.position = new Vector3(transform.position.x, oldY, transform.position.z);
        ////    tuzak�stte = false;
        ////    tuzakaltta =true;
        ////}




    }
    //private IEnumerator StartTimer(float duration)
    //{
       
    //    // Wait for the specified duration
    //    yield return new WaitForSeconds(duration);

    //    // Code to execute after the timer finishes
    //    Debug.Log("Timer finished!");

    //}

    
    

}
