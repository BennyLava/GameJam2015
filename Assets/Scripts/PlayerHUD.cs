﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHUD : MonoBehaviour {

    public Slider[] healthSliders;
    public Image[] playerIcon;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < healthSliders.Length; i++)
        {
            if (CharacterController.instance[i] != null)
                healthSliders[i].value = CharacterController.instance[i].health / 100f;
            else
                playerIcon[i].color = Color.gray;
                
        }
	}
}