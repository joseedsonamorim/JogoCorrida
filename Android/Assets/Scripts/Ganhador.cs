using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ganhador : MonoBehaviour
{



    public void OnTriggerEnter(Collider other)
    {
      

        if (other.gameObject.CompareTag("CarEnemy1"))
        {
            SceneManager.LoadScene("Perdeu");

        }
    }


    
}
