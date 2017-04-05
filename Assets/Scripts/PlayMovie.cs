using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayMovie : MonoBehaviour {

	// Use this for initialization
	void Start () {
        ((MovieTexture)GetComponent<Renderer>().material.mainTexture).Play();
    }

    void Update()
    {
        if (!((MovieTexture)GetComponent<Renderer>().material.mainTexture).isPlaying)
        {
            SceneManager.LoadScene("main");
        }
    }
}