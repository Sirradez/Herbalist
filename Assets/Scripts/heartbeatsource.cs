using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartbeatsource : MonoBehaviour
{
    public AudioSource hearbeatsound;
     public float fadeTime = 5;
    public float minTijdUit = 5;

    public float maxTijdUit = 15;

    float tijdUit;
    public float minTijdAan = 5;
    public float maxTijdAan = 15;
    float tijdAan;
    public float minVol = 1f;
    public float maxVol = 1;
    float hbvolume;
    public float timer;
    public float naarvolgende;

        bool heartbeatplaying;
    // Start is called before the first frame update
    void Start()
    {

        RandomValue();
        naarvolgende = tijdUit;


    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        if(timer > naarvolgende)
        {
            if (heartbeatplaying)
            {
                StartCoroutine(fadeheartbeat(hearbeatsound.volume, 1, fadeTime));
                heartbeatplaying = false;
                RandomValue();
                naarvolgende = tijdUit + fadeTime;

            }
            else if (!heartbeatplaying)
            {
                StartCoroutine(fadeheartbeat(1, hbvolume, fadeTime));
                heartbeatplaying = true;
                RandomValue();
                naarvolgende = tijdAan + fadeTime;
            }
            timer = 0;
        }


    }


    void RandomValue()
    {
        tijdUit = Random.Range(minTijdUit, maxTijdUit);
        tijdAan = Random.Range(minTijdAan, maxTijdAan);
        hbvolume = Random.Range(minVol, maxVol);

    }

    IEnumerator fadeheartbeat(float startValue, float endValue, float duration)
    {

        float currentTime = 0;

        while(currentTime <= duration)
        {
            hearbeatsound.volume = Mathf.Lerp(startValue, endValue, (currentTime / duration));
            currentTime += Time.deltaTime;

            yield return null;
        }
    }
}
