using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSource : MonoBehaviour
{
    private int damageAmount;

    private void Start() {
        MonoBehaviour currenActiveWeapon = ActiveWeapon.Instance.CurrentActiveWeapon;
        damageAmount = (currenActiveWeapon as IWeapon).GetWeaponInfo().weaponDamage;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        EnemyHealth enemyHealth = other.gameObject.GetComponent<EnemyHealth>();
        enemyHealth?.TakeDamage(damageAmount);
    }
}
