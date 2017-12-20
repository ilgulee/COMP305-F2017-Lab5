using UnityEngine;

namespace Assets.Scripts
{
    public class BombSpawn : MonoBehaviour
    {

        public GameObject Bomb;

        private int numberOfBombs = 1;

        // Use this for initialization
        void Start () {
		
        }
	
        // Update is called once per frame
        void Update () {
            if (Input.GetButtonDown("Jump") && numberOfBombs >= 1)
            {
                Vector2 spawnPosition=new Vector2(Mathf.RoundToInt(transform.position.x),Mathf.RoundToInt(transform.position.y));
                Instantiate(Bomb, spawnPosition, Quaternion.identity);
                numberOfBombs--;
                //timelapse between placing bombs for 1 sec
                Invoke("AddBomb",1);
            }	
        }

        private void AddBomb()
        {
            numberOfBombs++;
        }
    }
}
