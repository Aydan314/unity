using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public ScoreSystem scoreSystem;
    public TMPro.TextMeshProUGUI uiLabel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void addScore(int amount)
    {
        if (amount == 0)
        {
            scoreSystem.score += Random.Range(1, 10);
        }
        else scoreSystem.score += amount;

        uiLabel.text = "Robux " + scoreSystem.score;
    }
}
