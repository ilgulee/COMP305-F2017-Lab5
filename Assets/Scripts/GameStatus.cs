using UnityEngine;

namespace Assets.Scripts
{
    public class GameStatus : MonoBehaviour {

        public int GoldCoins = 0;

        public int SilverCoins = 0;

        public int BronzeCoins = 0;

        private static GameStatus _instance;

        public static GameStatus GetInstance()
        {
            return _instance;
        }
        // Use this for initialization
        void Start()
        {
            if (_instance != null)
            {
                Destroy(this.gameObject);
                return;
            }
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
