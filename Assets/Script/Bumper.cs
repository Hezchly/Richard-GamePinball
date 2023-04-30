using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
  
    public Collider bola;
    public float multiplier;
    public Color color;
    public float score;

    public AudioManager audioManager;
    public VFXManager VFXManager;
    public ScoreManager scoreManager;

    private Renderer renderer;
    private Animator animator;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        animator = GetComponent<Animator>();

        renderer.material.color = color;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == bola)
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;

            animator.SetTrigger("Hit");
            audioManager.PlaysfxAudioSource(collision.transform.position);
            VFXManager.PlayvfxBumperSource(collision.transform.position);

            scoreManager.AddScore(score);
        }
    }
}
