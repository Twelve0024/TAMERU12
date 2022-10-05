using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Death : MonoBehaviour
{
	// オブジェクトと接触した時に呼ばれるコールバック
	void OnCollisionEnter(Collision hit)
	{
		// 接触したオブジェクトのタグが"Player"の場合
		if (hit.gameObject.CompareTag("death"))
		{
			//DelayMethodを1秒後に呼び出す
			Invoke("coal", 1f);
		}
	}

	void coal()
	{
		// 現在のSceneを取得
		Scene loadScene = SceneManager.GetActiveScene();
		// 現在のシーンを再読み込みする
		SceneManager.LoadScene(loadScene.name);
		Debug.Log("!!");
	}
}