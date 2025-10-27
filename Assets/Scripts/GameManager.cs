using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    public GameObject WallObj;
    public GameObject EnemyObj;
    [SerializeField] private AudioClip _AudioClip;
    [SerializeField] private AudioSource _AudioSource;
    public bool flagEnemy=false;
    public float updateInterval = 0.5f; 

    float accum = 0.0f;
    int frames = 0;
    float timeleft;
    float fps;

    GUIStyle textStyle = new GUIStyle();

    void Start()
    {
        timeleft = updateInterval;

        textStyle.fontStyle = FontStyle.Bold;
        textStyle.normal.textColor = Color.white;
    }

    void Update()
    {
        if (flagEnemy)
        {
            WallObj.SetActive(false);
            EnemyObj.SetActive(true);
            _AudioSource.loop = true;
            _AudioSource.PlayOneShot(_AudioClip);
            flagEnemy = false;

        }

        timeleft -= Time.deltaTime;
        accum += Time.timeScale / Time.deltaTime;
        ++frames;

        if (timeleft <= 0.0)
        {
            // display two fractional digits (f2 format)
            fps = (accum / frames);
            timeleft = updateInterval;
            accum = 0.0f;
            frames = 0;
        }
    }

    void OnGUI()
    {
        GUI.Label(new Rect(5, 5, 100, 25), fps.ToString("F2") + "FPS", textStyle);
    }
}
