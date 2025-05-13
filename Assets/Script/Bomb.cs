using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public int Hp = 3;
    public GameObject Effect;

    //public TMP_Text txtCount; <이건 캔버스 UI 버전
    public XRHpBar hpBar; // <이건 옆에 놓인 HP 바 버전

    public void TrvBomb()
    {
        Hp--;

        UpdateHPUI();

        if (Hp <= 0)
        {
            Instantiate(Effect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

    void UpdateHPUI()
    {
        //txtCount.text = Hp.ToString(); <이건 캔버스 UI 버전
        hpBar.SetHP(Hp); // <이건 옆에 놓인 HP 바 버전
    }

}
