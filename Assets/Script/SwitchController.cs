using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    private enum SwitchState
    {
        Off,
        On,
        Blink
    }

    public Collider Bola;
    public Material offMaterial;
    public Material onMaterial;
    public AudioManager audioManager;
    public VFXManager VFXManager;

    private Renderer renderer;
    private SwitchState state;

    private void Start()
    {
        renderer = GetComponent<Renderer>();

        Set(false);

        StartCoroutine(BlinkTimerStart(5));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == Bola)
        {
            Toggle();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == Bola)
        {
            Toggle();
        }
    }
    private void Set(bool active)
    {
        if (active == true)
        {
            state = SwitchState.On;
            renderer.material = onMaterial;
            StopAllCoroutines();
            audioManager.PlaysfxAudioSource2(Bola.transform.position);
        }
        else
        {
            state = SwitchState.Off;
            renderer.material = offMaterial;
            StartCoroutine(BlinkTimerStart(5));
            audioManager.PlaysfxAudioSource3(Bola.transform.position);
        }

    }

    private void Toggle()
    {
        if (state == SwitchState.On)
        {
            Set(false);
            VFXManager.PlayvfxSwitchSource(Bola.transform.position);

        }
        else
        {
            Set(true);
            VFXManager.PlayvfxSwitchSource(Bola.transform.position);
        }
    }

    private IEnumerator Blink(int times)
    {
        state = SwitchState.Blink;

        for (int i = 0; i < times; i++)
        {
            renderer.material = onMaterial;
            yield return new WaitForSeconds(0.5f);
            renderer.material = offMaterial;
            yield return new WaitForSeconds(0.5f);

        }

        state = SwitchState.Off;

        StartCoroutine(BlinkTimerStart(5));
    }

    private IEnumerator BlinkTimerStart(float time)
    {
        yield return new WaitForSeconds(time);
        StartCoroutine(Blink(2));
    }
}
