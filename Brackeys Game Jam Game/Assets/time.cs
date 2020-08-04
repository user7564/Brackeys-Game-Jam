using UnityEngine.SceneManagement;
using UnityEngine;
using System;
using UnityEngine.UI;

public class time : MonoBehaviour
{
    public Text timeclock;
    public float timeofday;
    // Update is called once per frame
    void Update()
    {
        timeofday += Time.deltaTime / 30;

        timeclock.text = (timeofday.ToString("0"));

        if (timeofday > 24)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            timeofday = 0;
        }

        if (Input.GetKey("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            timeofday = 0;
        }
    }
}
