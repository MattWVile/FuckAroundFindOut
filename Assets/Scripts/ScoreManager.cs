using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    public static int score;
    public TMPro.TextMeshProUGUI ScoreText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        score++;
        ScoreText.text = score.ToString();
    }
}
