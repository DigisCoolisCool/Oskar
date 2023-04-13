using UnityEngine;
using System.Collections;

public class GameScript : MonoBehaviour {
	public EnemySpawner enemySpawner;
	public int enemiesToSpawn;
	public int waweToWin=4;
	public int waweCount;
	public GameObject cutScene;




	// Use this for initialization
	protected void Start () {

		enemiesToSpawn = Random.Range(1, 5);


	
	}




	 public void Spawnwawe()
    {
		for (int i = 0; i < enemiesToSpawn; i++)
		{
			enemySpawner.Spawn();
		}
	}

	// Update is called once per frame
	protected void Update () 
	{
        if (EnemySpawner.activated && enemySpawner.transform.childCount==0 ){
            if (waweCount>waweToWin)
            {
				cutScene.SetActive(true);
				enemySpawner.gameObject.SetActive(false);
            }
            if (waweCount<waweToWin)

            {
				waweCount++;
				HUD.Message("round " + waweCount + " fight");
				Spawnwawe();
			}
			
		}
	}
}