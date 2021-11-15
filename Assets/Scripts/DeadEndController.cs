using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//это библиотека для работы со сценами
using UnityEngine.SceneManagement;

public class DeadEndController : MonoBehaviour {

//запустится если 2D collider попал в триггер
void OnTriggerEnter2D (Collider2D other) {
//проверка, имеет ли объект тэг Player
if (other.tag == "Player") {
//ппосмотреть название текущей сцены и загрузить её (reload)
SceneManager.LoadScene (SceneManager.GetActiveScene().name);
}
}
}