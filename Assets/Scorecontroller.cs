using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorecontroller : MonoBehaviour {

	//スコアを表示するテキスト
	private GameObject scoreText;

	//現在の得点
	int score = 0;


	// Use this for initialization
	void Start () {

		//シーン中のTextを取得する
		this.scoreText = GameObject.Find("ScoreText");

		//現在の得点を表示
		this.scoreText.GetComponent<Text>().text = score.ToString();
		
	}
	
	// Update is called once per frame
	void Update () {

		//ScoreTextに現在の得点を表示する
		this.scoreText.GetComponent<Text>().text = score.ToString();
	
		
	}


	//それぞれのオブジェクトにぶつかったとき、それぞれの得点を追加する
	void OnCollisionEnter (Collision other){
		
		if (other.gameObject.tag == "SmallStarTag") {
			this.score += 5;
		} else if (other.gameObject.tag == "LargeStarTag") {
			this.score += 50;
		} else if (other.gameObject.tag == "smallCloudTag" || other.gameObject.tag == "LargeCloudTag") {
			this.score += 10;
		}
	
	}

}