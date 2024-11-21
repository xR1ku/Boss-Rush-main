using UnityEngine;

namespace BossFight
{
    public class InitialState : BossState
    {
        public InitialState(Boss boss) : base(boss) { }

        public override void Enter()
        {
            Debug.Log("Boss entered Initial State.");
            // Set up initial attack patterns or behavior
        }

        public override void Update()
        {
            // Perform basic attack logic, like simple melee attacks
            boss.MeleeAttack();
        }

        public override void Exit()
        {
            Debug.Log("Boss exiting Initial State.");
        }
    }
}
