using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRampController : MonoBehaviour
{
    public Collider Bola;

    public ScoreManager scoreManager;

    public float score;

    private void OnTriggerEnter(Collider other)
    {
        if (other == Bola)
        {
           scoreManager.AddScore(score);
        }
 
    }
}
