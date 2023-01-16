using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadAsync : MonoBehaviour
{
    public void StartRoutine(string scene)
    {
        StartCoroutine(LoadScene(scene));
    }
    public IEnumerator LoadScene(string scene)
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadSceneAsync(scene);
    }
	public void Login(string scene)
    {
        if(PlayerPrefs.HasKey("Name")) StartRoutine("Menu");
        else StartRoutine(scene); //going to make the login screen a panel in menu scene to be able to better control everything.
    }		
}
