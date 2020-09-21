using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class SceneTime : MonoBehaviour
{
    [SerializeField]
    private float time = 60f;

    [SerializeField]
    private string sceneName;

    private float timeTaken;

    // Update is called once per frame
    void Update()
    {
        timeTaken += Time.deltaTime;

        if (timeTaken > time)
        {
            Application.LoadLevel(sceneName);
        }

    }
}
