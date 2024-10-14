using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnlookEvent;


    protected bool isAttacking { get; set; }

    //private float timeSinceLastAttack = float.MaxValue;

    // protected ������Ƽ�� �� ���� : ���� �ٲٰ������ �������°� �� ��ӹ޴� Ŭ�����鵵 �� �� �ְ�!
    protected CharacterStatHandler stats {  get; private set; }

    protected virtual void Awake()
    {
        stats = GetComponent<CharacterStatHandler>();
    }

    private void Update()
    {
        //HandleAttackDelay();
    }

    private void HandleAttackDelay()
    {
        //TODO::MAGIC NUMBER ����
        //if (timeSinceLastAttack < stats.CurrentStat.attackSO.delay)
        //{
        //    timeSinceLastAttack += Time.deltaTime;
        //}
        //else if (isAttacking && timeSinceLastAttack >= stats.CurrentStat.attackSO.delay)
        //{
        //    timeSinceLastAttack = 0f;
        //    CallatttackEvent(stats.CurrentStat.attackSO);
        //}


    }

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnlookEvent?.Invoke(direction);
    }
}
