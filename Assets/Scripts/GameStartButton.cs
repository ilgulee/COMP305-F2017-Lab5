﻿using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
	public class GameStartButton : MonoBehaviour {

		// Use this for initialization
		void Start () {
		
		}
	
		// Update is called once per frame
		void Update () {
		
		}

	    public void GameStart()
	    {
	        SceneManager.LoadScene("main");
	    }

	   
	}
}
