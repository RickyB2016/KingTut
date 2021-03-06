using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextImporter : MonoBehaviour 
{

	public GameObject textBox;
	public Text theText;

	public TextAsset textFile;
	public string[] textLines;

	public int currentLine;
	public int endAtLine;

	// Use this for initialization
	void Start () 
	{
		
		if (textFile != null)
		{
			textLines = (textFile.text.Split ('\n'));

		}
			
		if (endAtLine == 0) 
		{
			endAtLine = textLines.Length - 1;
		}

	}

	void OnTriggerEnter(Collider other)
	{
		textBox.SetActive (true);

	}

	void Update()
	{
		theText.text = textLines [currentLine];


		if (Input.GetKeyDown(KeyCode.Space))
		{
			textBox.SetActive (false);
		}

	}
}
