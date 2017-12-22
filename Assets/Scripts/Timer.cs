using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class Timer : MonoBehaviour
    {
        private float _timer;

        private int _seconds;

        // Use this for initialization
        void Start ()
        {
            _timer = 30;
            _seconds = 0;
        }
	
        // Update is called once per frame
        void Update ()
        {
            _timer -= Time.deltaTime;
            _seconds = (int) (_timer);
            //print("time remaining "+_seconds);
            GameObject.Find("timerUI").GetComponent<Text>().text = "Time Remaining: " + (_seconds);
            if (_seconds <= 0)
            {
                SceneManager.LoadScene("end");
            }
        }
    }
}
