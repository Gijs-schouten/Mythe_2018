using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAttack : MonoBehaviour {

    private EnemyController _isAttacking;
    private NavMeshAgent NavM;
    private EnemyHealth _isAlive;

    void Start() {
        NavM = GetComponent<NavMeshAgent>();
        _isAlive = gameObject.GetComponent<EnemyHealth>();
        _isAttacking = gameObject.GetComponent<EnemyController>();
    }

    // Update is called once per frame
    void Update () {
        if (_isAttacking.isAttacking & _isAlive.isAlive) {
            NavM.speed = 0;
        }
        
    }
}
