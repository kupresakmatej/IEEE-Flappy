using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [Header("Elements")]
    [SerializeField] private Text scoreText;

    private int score;

    void Start()
    {
        score = 0;

        scoreText.text = score.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Pillar Trigger")
        {
            score += 1;

            scoreText.text = score.ToString();
        }
    }
}
