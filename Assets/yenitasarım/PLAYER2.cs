using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PLAYER2 : MonoBehaviour
{
    public Canvas keycanvas;
    public Canvas keycanvas2;
    public Canvas keycanvas3;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Key1"))
        {
           // bool lv1 = true;
            Destroy(GameObject.FindWithTag("Key1"));
            Debug.Log("Item2 entered trigger zone");
            keycanvas.gameObject.SetActive(true);
            FindObjectOfType<Door1>().DoorOpen1();
           // keycontrol1 = true;
        }
        if (collision.gameObject.CompareTag("Key2"))
        {
            //bool lv2 = true;
            Destroy(GameObject.FindWithTag("Key2"));
            Debug.Log("Item2 entered trigger zone key2");
            keycanvas2.gameObject.SetActive(true);
            FindObjectOfType<Door2>().DoorOpen2();
            //keycontrol2 = true;
        }
        if (collision.gameObject.CompareTag("Key3"))
        {

            Destroy(GameObject.FindWithTag("Key3"));
            Debug.Log("Item2 entered trigger zone key3");
            keycanvas3.gameObject.SetActive(true);
            FindObjectOfType<Door3>().DoorOpen3();
            //keycontrol3 = true;
        }
        Debug.Log("aaa");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Dia"))
        {
            Cursor.lockState = CursorLockMode.Confined;
            SceneManager.LoadScene(3);
        }
    }
}
