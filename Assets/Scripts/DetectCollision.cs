using UnityEngine;

namespace Assets.Scripts
{
	public class DetectCollision : MonoBehaviour
	{
		private int _goldCoin;

		private int _silverCoin;

		private int _bronzeCoin;

		// Use this for initialization
		void Start () {
		
		}
	
		// Update is called once per frame
		void Update () {
		
		}

		void OnCollisionEnter2D(Collision2D coll)
		{
			string tag = coll.collider.gameObject.tag;
			if (tag == "pick_coin")
			{
				string coinKind = coll.collider.gameObject.name;
				switch (coinKind)
				{
					case "Gold Coin":
						_goldCoin++;
						print(coinKind+": "+_goldCoin);
						break;
					case "Silver Coin":
						_silverCoin++;
						print(coinKind + ": " + _silverCoin);
						break;
					case "Bronze Coin":
						_bronzeCoin++;
						print(coinKind + ": " + _bronzeCoin);
						break;
				}
				
				Destroy(coll.collider.gameObject);
			}
		}
	}
}
