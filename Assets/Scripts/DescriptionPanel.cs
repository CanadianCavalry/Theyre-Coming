﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DescriptionPanel : MonoBehaviour {

	public Text panelText;

	public void showDescription(string text) {
		gameObject.SetActive(true);
		StartCoroutine ("ShowDescription", text);
	}

	IEnumerator ShowDescription(string text) {
		gameObject.SetActive(true);
		panelText.text = text;

		yield return new WaitForSeconds (4.0f);

		panelText.text = "";
		gameObject.SetActive(false);
	}
}
