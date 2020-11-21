using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    public TextMeshProUGUI guessText;
    public GameObject buttonOne;
    public GameObject buttonTwo;
    public GameObject buttonThree;
    public GameObject buttonFour;


    int min = 1;
    int max = 200;
    int guess;

    

    // Start is called before the first frame update
    void Start()
    {
        Restart();
        
    }


    private void NextGuess()
    {
        guess = (min + max) / 2;
        // Debug.Log("Guess" + guess);
      
        guessText.text = guess.ToString();


    }
    public void Lower()
    {
        max = guess - 1;
        
        NextGuess();

    }
    public void Higher()
    {
        min = guess + 1;

        NextGuess();

    }
    public void Correct()
    {
       
        buttonOne.SetActive(false);
        buttonTwo.SetActive(false);
        buttonThree.SetActive(false);
        buttonFour.SetActive(true);
         

    }
    public void Restart()
    {
        min = 1;
        max = 200;
        NextGuess();
        buttonOne.SetActive(true);
        buttonTwo.SetActive(true);
        buttonThree.SetActive(true);
        buttonFour.SetActive(false);
    }

}