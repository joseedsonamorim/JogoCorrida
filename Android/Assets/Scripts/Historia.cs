using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Historia : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public int contador = 0;
    public GameObject continueBottom;



    void Start()
    {
        StartCoroutine(Type());
    }

    void Update()
    {
        if (index == -1)
        {
            Debug.Log("Chegou");
            SceneManager.LoadScene(1);
        }

        if (textDisplay.text == sentences[index])
        {
            continueBottom.SetActive(true);
        }
        Debug.Log("Uindex" + index);

    }
    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }


    public void nextSentences()

    {
        continueBottom.SetActive(false);
        Debug.Log("index" + index);

        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            index = -1;
            textDisplay.text = "";
            continueBottom.SetActive(false);
        }


    }
}
