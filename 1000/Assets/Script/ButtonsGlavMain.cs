using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsGlavMain : MonoBehaviour {
	bool paused = false;
	public GameObject TouchOne, TouchLeftTou, TouchRightTou, TouchThree;
	public Text one, tou, three,shop, close; // закрыть и магазин аналогично шопу
	public GameObject GameOne, GameTou, GameThree, ShopGameTou, whithCube; //ShopGameTou - (перенисти также - это пробное)
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnMouseUpAsButton () {
		switch (gameObject.name) {
		case "One":
			TouchOne.SetActive(true);
			GameOne.SetActive (true);
			one.gameObject.SetActive(false);
			tou.gameObject.SetActive(false);
			three.gameObject.SetActive(false);
			break;
		case "Tou":
			TouchLeftTou.SetActive (true);
			TouchRightTou.SetActive (true);
			GameTou.SetActive (true);
			one.gameObject.SetActive(false);
			tou.gameObject.SetActive(false);
			three.gameObject.SetActive(false);
			break;
		case "Three":
			TouchThree.SetActive (true);
			GameThree.SetActive (true);
			one.gameObject.SetActive(false);
			tou.gameObject.SetActive(false);
			three.gameObject.SetActive(false);
			break;
			//скрипт про магазин тут пробный потом перенисти его в другой крипт (не для главного меню)
		case "ShopG2":
			if (!paused)
				Time.timeScale = 0;
			shop.gameObject.SetActive (false);
			TouchLeftTou.SetActive (false);
			TouchRightTou.SetActive (false);
			ShopGameTou.SetActive (true);
			break;
			// аналогично  шопу!
		case "Close":
			Time.timeScale = 1;
			shop.gameObject.SetActive (true);
			TouchLeftTou.SetActive (true);
			TouchRightTou.SetActive (true);
			ShopGameTou.SetActive (false);
			GameTou.SetActive (true);
			break;
		case "arrow-left":
			whithCube.transform.position = new Vector3 (transform.position.x - 0.135f, 0f,-7.9f);
			break;
		case "arrow-right":
			whithCube.transform.position = new Vector3 (transform.position.x + 0.135f, 0f,-7.9f);
			break;
		}
	}
}
