using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehavior4 : MonoBehaviour
{
    public GameBehavior gameManager;
	//public GameObject bullet;
	//public float bulletSpeed = 100f;
	public MeshRenderer Slingshot;

	void Start()
	{
		gameManager = GameObject.Find("GameManager").GetComponent<GameBehavior>();
	}
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.name == "Player")
		{
			GetComponent<AudioSource>().Play();
			Destroy(this.transform.parent.gameObject);
			Debug.Log("You found better Ammo! You now deal 10 damage!");
			PlayerBehavior Player = collision.gameObject.GetComponent<PlayerBehavior>();
			EnemyBehavior Enemy = gameObject.GetComponent<EnemyBehavior>();
			gameManager.Items +=1;
			gameManager.HP += 1;
			Slingshot.enabled = true;
			Enemy.bulletDamage = 10;
		}
	}
}