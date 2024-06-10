using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrapDamage : MonoBehaviour
{
    public int health = 100;
    MainMenu mainMenu;

    private void Start()
    {
        mainMenu = GetComponent<MainMenu>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trap"))
        {
            health -= 25;
        }
        if (other.CompareTag("Trap") && health == 0)
        {
            Cursor.lockState = CursorLockMode.Confined;
            SceneManager.LoadScene(2);
        }
    }   
}
