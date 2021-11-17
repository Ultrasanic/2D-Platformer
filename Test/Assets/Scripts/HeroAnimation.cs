using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroAnimation : MonoBehaviour
{
//ссылочная переменная для аниматора
Animator anim;
//ссылочная переменная для rigidbody2D
Rigidbody2D rb;
//ссылочная переменная для HeroMove
HeroMove pm;

void Start () {
//делаем ссылку на Animator
anim = GetComponent <Animator> ();
//делаем ссылку на Rigidbody2D
rb = GetComponent <Rigidbody2D> ();
//делаем ссылку на PlayerMove
pm = GetComponent <HeroMove> ();
}

void Update () {
//проверка, находится ли крыса на земле
if (pm.isGrounded) {
//меняем параметр isJumping на false
anim.SetBool ("isJumping", false);
//меняем параметр speed. Используем абсолютное значение вектора скорости по х
anim.SetFloat ("speed", Mathf.Abs (rb.velocity.x));
// если крыса не на земле
} else {
//меняем параметр speed на 0
anim.SetFloat ("speed", 0);
//меняем параметр isJumping на true
anim.SetBool ("isJumping", true);
}
}

}