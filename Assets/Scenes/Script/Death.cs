using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Death : MonoBehaviour
{
	// �I�u�W�F�N�g�ƐڐG�������ɌĂ΂��R�[���o�b�N
	void OnCollisionEnter(Collision hit)
	{
		// �ڐG�����I�u�W�F�N�g�̃^�O��"Player"�̏ꍇ
		if (hit.gameObject.CompareTag("death"))
		{
			//DelayMethod��1�b��ɌĂяo��
			Invoke("coal", 1f);
		}
	}

	void coal()
	{
		// ���݂�Scene���擾
		Scene loadScene = SceneManager.GetActiveScene();
		// ���݂̃V�[�����ēǂݍ��݂���
		SceneManager.LoadScene(loadScene.name);
		Debug.Log("!!");
	}
}