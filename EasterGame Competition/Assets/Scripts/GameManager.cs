using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

    public int score;
    public int highscore;
    public int[] notes;
    public int notesHit;
    public Text scoreDisplay;

    void Start()
    {
        
    }

    void Update()
    {

    }

    void OnGUI()
    {
        scoreDisplay.text = "Score: " + score;
    }

}
