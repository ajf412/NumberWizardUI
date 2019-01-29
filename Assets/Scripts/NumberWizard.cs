using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max, min;
    [SerializeField] TextMeshProUGUI guessText;

    int guess;

    // Start is called before the first frame update
    void Start()
    {
        
        StartGame();
    }

    // Game setup
    void StartGame()
    {
        NextGuess();
    }

    // "Go Higher..." button
    public void OnPressHigher()
    {
        min = guess+1;
        NextGuess();
    }

    // "Go Lower..." button
    public void OnPressLower()
    {
        max = guess-1;
        NextGuess();
    }

    // Set the "guess" variable
    void NextGuess()
    {
        guess = Random.Range(min, max);
        if (guess > 1000) guess = 1000;
        if (guess < 1) guess = 1;
     
        guessText.text = guess.ToString();
    }
}
