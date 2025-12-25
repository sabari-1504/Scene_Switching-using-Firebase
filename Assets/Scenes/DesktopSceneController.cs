using UnityEngine;
using UnityEngine.SceneManagement;
using Firebase;
using Firebase.Database;

public class DesktopSceneController : MonoBehaviour
{
    private static DesktopSceneController instance;
    private DatabaseReference sceneRef;
    private string lastLoadedScene = "";

    void Awake()
    {
        // Singleton
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    void Start()
    {
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task =>
        {
            if (task.Result == DependencyStatus.Available)
            {
                sceneRef = FirebaseDatabase.DefaultInstance
                            .GetReference("sceneControl/currentScene");

                sceneRef.ValueChanged += HandleSceneChange;
                Debug.Log("🔥 Firebase scene listener started");
            }
            else
            {
                Debug.LogError("❌ Firebase dependencies not resolved");
            }
        });
    }

    void HandleSceneChange(object sender, ValueChangedEventArgs args)
    {
        if (args.DatabaseError != null || args.Snapshot.Value == null)
            return;

        string firebaseSceneName = args.Snapshot.Value.ToString();

        // Avoid reloading same scene
        if (firebaseSceneName == lastLoadedScene)
            return;

        // Check if scene exists in Build Settings
        if (SceneExists(firebaseSceneName))
        {
            Debug.Log($"✅ Loading scene: {firebaseSceneName}");
            lastLoadedScene = firebaseSceneName;
            SceneManager.LoadScene(firebaseSceneName);
        }
        else
        {
            Debug.LogWarning($"⚠️ Scene '{firebaseSceneName}' not found in Build Settings");
        }
    }

    bool SceneExists(string sceneName)
    {
        for (int i = 0; i < SceneManager.sceneCountInBuildSettings; i++)
        {
            string path = SceneUtility.GetScenePathByBuildIndex(i);
            string name = System.IO.Path.GetFileNameWithoutExtension(path);

            if (name == sceneName)
                return true;
        }
        return false;
    }

    void OnDestroy()
    {
        if (sceneRef != null)
        {
            sceneRef.ValueChanged -= HandleSceneChange;
        }
    }
}
