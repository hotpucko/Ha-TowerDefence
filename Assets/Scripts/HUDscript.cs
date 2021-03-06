﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class HUDscript : MonoBehaviour {

	public enum Towers {Tower1, Tower2, Tower3, none}
	public Towers selectedTower;
    public static int cash = 200;
    public List<GameObject> TowerPrefabList = new List<GameObject>();

    

    Tower tower;
    
	void OnGUI()
	{
		if (GUI.Button (new Rect (Screen.width / 2, 50, 125, 50), "Fast Tower " + TowerPrefabList[0].GetComponent<GoldCost>().Cost + "g")) 
		{
			if(selectedTower == Towers.Tower1)
				selectedTower = Towers.none;
			else
				selectedTower = Towers.Tower1;
		}
		if (GUI.Button (new Rect (Screen.width / 2, 100, 125, 50), "Mortar " + TowerPrefabList[1].GetComponent<GoldCost>().Cost + "g")) 
		{
			if(selectedTower == Towers.Tower2)
				selectedTower = Towers.none;
			else
				selectedTower = Towers.Tower2;
		}
		if (GUI.Button(new Rect(Screen.width / 2, 150, 125, 50), "Strong tower " + TowerPrefabList[2].GetComponent<GoldCost>().Cost + "g"))
            {
                if (selectedTower == Towers.Tower3)
                    selectedTower = Towers.none;
                else
                    selectedTower = Towers.Tower3;
            }

		GUI.Label (new Rect (Screen.width / 2, 0, 100, 70), selectedTower.ToString());
        GUI.Label(new Rect(Screen.width / 2 + 150, 0, 100, 70), cash.ToString() + "g");
	}

	// Use this for initialization
	void Start () {
	
		selectedTower = Towers.none;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
