using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Audio;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class PauseManager : MonoBehaviour {
	
	public AudioMixerSnapshot paused;
	public AudioMixerSnapshot unpaused;
	public AudioMixerSnapshot mySnapshot;
	
	Canvas canvas;
	
	void Start()
	{
		canvas = GetComponent<Canvas>();
	}
	
	void Update()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) {
			canvas.enabled = !canvas.enabled;
			Pause ();
		} else if (Input.GetKeyDown (KeyCode.A)) {
			mySnapshot.TransitionTo (.01f);
		}
	}
	
	public void Pause()
	{
		Time.timeScale = Time.timeScale == 0 ? 1 : 0;
		Lowpass ();
		
	}
	
	void Lowpass()
	{
		if (Time.timeScale == 0)
		{
			paused.TransitionTo(.01f);
		}
		
		else
			
		{
			unpaused.TransitionTo(.01f);
		}
	}
	
	public void Quit()
	{
		#if UNITY_EDITOR 
		EditorApplication.isPlaying = false;
		#else 
		Application.Quit();
		#endif
	}
}
