using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//эта библиотека нужна для работы с интерфейсом
using UnityEngine.UI;

public class CoinController : MonoBehaviour {

//ссылка на объект с текстом
public GameObject TextObject;
//ссылка на текстовый компонент
Text textComponent;
//звук поднятия монеты
public AudioClip CoinSound;
//переменная подсчета монет
public int coin;

//запустится один раз при запуске скрипта
void Start () {
//делаем линк на текстовый компонент, который находится на текстовом объекте
textComponent = TextObject.GetComponent <Text> ();
}

//запустится если collider2D попал в триггер
void OnTriggerEnter2D (Collider2D other) {
//проверка, имеет-ли объект тэг Coin
if (other.tag == "Coin") {
//увеличить переменную подсчета монет
coin = coin + 1;
//записать в текст результат счета монет, преобразованный в текстовую переменную
textComponent.text = "Количество монет: " + coin.ToString();
//проиграть звук поднятия монеты на позиции крысы
AudioSource.PlayClipAtPoint (CoinSound, transform.position);
//удалить монету из сцены
Destroy (other.gameObject);
}
}
}