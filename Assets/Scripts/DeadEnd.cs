using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//это библиотека для работы со сценами
using UnityEngine.SceneManagement;

public class DeadEnd : MonoBehaviour {
[SerializeField] // Указывается в инспекторе
GameObject Hero; // Объект, на котором Script1public GameObject PrefabCoin;
public GameObject TextObject;
Text textComponent;


//запустится один раз при запуске скрипта
void Start () {
//делаем линк на текстовый компонент, который находится на текстовом объекте
textComponent = TextObject.GetComponent <Text> ();
}


//запустится если 2D collider попал в триггер
void OnTriggerEnter2D (Collider2D other) {
//проверка, имеет ли объект тэг Player
if (other.tag == "Player") {
//ппосмотреть название текущей сцены и загрузить её (reload)
//SceneManager.LoadScene (SceneManager.GetActiveScene().name);
Hero.GetComponent<CoinController>().coin = 0;
int coin = Hero.GetComponent<CoinController>().coin;
Hero.transform.position = new Vector2(-6,-3);

//записать в текст результат счета монет, преобразованный в текстовую переменную
textComponent.text = "Количество монет: " + coin.ToString();

}
}
}
