using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class heartSystem : MonoBehaviour {

	private int maxHeartAmount = 3;
	public int startHearts = 3;
	public int curHealth;
	private int maxHealth;
	private int healthPerHeart = 2;

	public Image[] healthImages;
	public Sprite[] healthSprites;

	// Use this for initialization
	void Start () 
	{
		curHealth = startHeart	* healthPerHeart;
		maxHealth = maxHeartAmount * healthPerHeart;
	}
	
	void checkHealthAmount()
	{
		for (int i = 0; i < maxHeartAmount; i++) 
		{
		
			if (startHearts <= i) {
				healthImages [i].enabled = false;
			} 

			else 
			{
				healthImages [i].enabled = true;
			}
		}
	}

	void UpdateHearts()
	{
		bool empty false;
		int i = 0;
		foreach(Image image in healthImages)
		{
			if(empty)
			{
				image.sprite = healthSprites[0];
			}
		}
	}





}
