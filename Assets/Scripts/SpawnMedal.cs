using UnityEngine;

namespace Assets.Scripts
{
    public class SpawnMedal : MonoBehaviour
    {
       
        public GameObject[] Coins = new GameObject[3];

    // Use this for initialization
        void Start ()
        {
          
            InvokeRepeating("SpawnCoins", 0, 0.5f);
        }

        // Update is called once per frame
        void Update () {
		
        }

        public void SpawnCoins()
        {
            int i = Random.Range(0,3);
            float x = Random.Range(-10, 10);
            float y = Random.Range(-10, 10);
            Vector2 positon=new Vector2(x,y);
            GameObject newCoin = Instantiate(Coins[i],positon,Quaternion.identity);
            newCoin.name = Coins[i].name;

        }
    }
}
