using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.UI;

public class Count : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int i = 0;
        int n = 100000000;
        while (i < n)
        {
            ++i;
        }
        if (i >= n)
        {
            SceneManager.LoadScene(0);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
