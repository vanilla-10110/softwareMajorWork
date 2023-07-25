using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour
{
    public Collider headCollider;
    public string sceneName;
    public string activeSceneName;

    public int targetSceneIndex;

    public GameObject itemManager;
    public GameObject player;
    public GameObject weapons;

    IEnumerator OnTriggerEnter(Collider collision)
    {
        if (collision.GetComponent<Collider>() == headCollider)
        {
            

            // Load the new scene additively
            AsyncOperation sceneLoadOperation = SceneManager.LoadSceneAsync(targetSceneIndex, LoadSceneMode.Additive);
            sceneLoadOperation.allowSceneActivation = false;

            while (sceneLoadOperation.progress < 0.9f)
            {
                yield return null;
               
            }

            sceneLoadOperation.allowSceneActivation = true; // Activate the scene

            // Get the current active scene dynamically
            Scene currentActiveScene = SceneManager.GetActiveScene();

            // Check if the 'main room' scene is loaded
            Scene mainRoomScene = SceneManager.GetSceneByName("main room");
            if (mainRoomScene.isLoaded)
            {
                // Set the 'main room' scene as active
                SceneManager.SetActiveScene(mainRoomScene);
                Debug.Log("Scene 'main room' set as active");
            }
            else
            {
                Debug.Log("Scene 'main room' is not loaded.");
            }

            // Unload the previous scene
            SceneManager.UnloadSceneAsync(currentActiveScene);

            // Move objects and set the new scene as the active scene
            Scene targetScene = SceneManager.GetSceneByBuildIndex(targetSceneIndex);
            SceneManager.MoveGameObjectToScene(itemManager, targetScene);
            SceneManager.MoveGameObjectToScene(player, targetScene);
            SceneManager.MoveGameObjectToScene(weapons, targetScene);
            SceneManager.SetActiveScene(targetScene);

            Debug.Log("Scene unloaded successfully");
        }
    }
}