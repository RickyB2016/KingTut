using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class laughingNinja : MonoBehaviour {


	void Start ()
	{ 
		StartCoroutine("Wait");

	}

	IEnumerator Wait()
	{
		yield return new WaitForSeconds(4);

		SceneManager.LoadScene("PressAnyKey");
	}
}