using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class ShowResult : MonoBehaviour {

        // Use this for initialization
        void Start () {
		
        }
	
        // Update is called once per frame
        void Update ()
        {
            GameObject.Find("Result").GetComponent<Text>().text = 
                "Gold Coins: " +
                GameStatus.GetInstance().GoldCoins +
                "  Silver Coins: " +
                GameStatus.GetInstance().SilverCoins +
                "  Bronze Coins: " + 
                GameStatus.GetInstance().BronzeCoins;
        }
    }
}
