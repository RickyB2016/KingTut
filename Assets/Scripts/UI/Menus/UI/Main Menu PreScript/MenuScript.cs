using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {

	public Canvas startMenu;
    public Canvas optionsMenu;
    public Canvas quitMenu;
    public Canvas levelSelect;
    public Button startText;
    public Button exitText;
    public Button optionsText;

	public AudioSource audio_source;
	public AudioClip audio_clip; 

	// Use this for initialization
	void Start () 
	{	
		startMenu =GetComponent<Canvas>();
        quitMenu = quitMenu.GetComponent<Canvas>();
        optionsMenu = optionsMenu.GetComponent<Canvas>();
        levelSelect = levelSelect.GetComponent<Canvas>();

        //startText = startText.GetComponent<Button>();
        //exitText = exitText.GetComponent<Button>();
        //optionsText = optionsText.GetComponent<Button>();
        optionsMenu.enabled = false;
        quitMenu.enabled = false;
        levelSelect.enabled = false;
    }
	
    public void OptionsPress()
    {
		audio_source.PlayOneShot (audio_clip, 1);

        quitMenu.enabled = false;
        startText.enabled = false;
        exitText.enabled = false;
        optionsMenu.enabled = true;
		optionsText.enabled = false;
		startMenu.gameObject.SetActive(false);	
    }

    public void ExitPress()
    {
		audio_source.PlayOneShot (audio_clip, 1);
        quitMenu.enabled = true;
        startText.enabled = false;
        exitText.enabled = false;
        optionsMenu.enabled = false;
		startMenu.gameObject.SetActive(false);

    }

    public void PlayPressed()
    {
        audio_source.PlayOneShot (audio_clip, 1);

        quitMenu.enabled = false;
        startText.enabled = false;
        exitText.enabled = false;
        optionsMenu.enabled = false;
        optionsText.enabled = false;
        levelSelect.enabled = true;
       
        startMenu.gameObject.SetActive(false);  
    }

    public void NoPress()
    {
		audio_source.PlayOneShot (audio_clip, 1);

        quitMenu.enabled = false;
        startText.enabled = true;
        exitText.enabled = true;
        optionsMenu.enabled = false;
		optionsText.enabled = true;
		startMenu.gameObject.SetActive(true);

    }

   
    public void ExitGame()
    {
		
		audio_source.PlayOneShot (audio_clip, 1);
        Application.Quit();
    }

    public void StartTutorial()
    {   
        audio_source.PlayOneShot (audio_clip, 1);

       SceneManager.LoadScene("TutorialLevel");

     }

    public void StartLevelOne()
    {   
        audio_source.PlayOneShot (audio_clip, 1);

		SceneManager.LoadScene("Level One Take 3");
    }
    public void StartLevelTwo()
    {   
        audio_source.PlayOneShot (audio_clip, 1);

		SceneManager.LoadScene("shaun level revised");
    }
  
}
