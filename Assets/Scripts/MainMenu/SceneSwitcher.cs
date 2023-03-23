using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{

    [SerializeField] private Animator transitionAnimator;
    [SerializeField] private string sceneName;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene()
    {
        StartCoroutine(SceneLoad());
    }

    public void Quit()
    {
        Application.Quit();
    }

    public IEnumerator SceneLoad(){
        transitionAnimator.SetTrigger("StartTransition");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(sceneName);
    }

}

