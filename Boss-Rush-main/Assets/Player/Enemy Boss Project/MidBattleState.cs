using UnityEngine;

namespace BossFight
{
    public class MidBattleState : BossState
    {
        public MidBattleState(Boss boss) : base(boss) { }

        public override void Enter()
        {
            Debug.Log("Boss entered Mid-Battle State.");
            // Increase attack intensity or add ranged attacks
        }

        public override void Update()
        {
            // More aggressive attacks, add combinations
            boss.RangedAttack();
        }

        public override void Exit()
        {
            Debug.Log("Boss exiting Mid-Battle State.");
        }
    }
}
