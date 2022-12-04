using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // Переменная для хранения имени сцены
    public string sceneName;


    // Метод когда касаемся ловушки
    public void OnTriggerEnter(Collider other)
    {
        print("Сработабо касание");
        EditorSceneManager.LoadScene(sceneName);
    }
}
