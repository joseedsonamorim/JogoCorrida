using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour {

    public GameObject Counter;
    public AudioSource GetReady;
    public AudioSource GoAudio;
    public GameObject LapTimer;
    public GameObject CarControls;
    

    void Start()
    {
        StartCoroutine(CountStart());
    }
       


    IEnumerator CountStart()
    {
        yield return new WaitForSeconds(0.5f);
        Counter.GetComponent<Text>().text = "3";
        GetReady.Play();
        Counter.SetActive(true);

        yield return new WaitForSeconds(1);
        Counter.SetActive(false);
        Counter.GetComponent<Text>().text = "2";
        GetReady.Play();
        Counter.SetActive(true);

        yield return new WaitForSeconds(1);
        Counter.SetActive(false);

        Counter.GetComponent<Text>().text = "1";
        GetReady.Play();
        Counter.SetActive(true);

        yield return new WaitForSeconds(1);
        Counter.SetActive(false);
        GoAudio.Play();
        LapTimer.SetActive(true);
        



    }


}