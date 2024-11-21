using UnityEngine;

namespace BossFight
{
    public class EnragedState : BossState
    {
        public EnragedState(Boss boss) : base(boss) { }

        public override void Enter()
        {
            Debug.Log("Boss entered Enraged State.");
            // Set ultimate attack preparation or very fast movement
        }

        public override void Update()
        {
            // Perform ultimate attacks or rapid attacks
            boss.UltimateAttack();
        }

        public override void Exit()
        {
            Debug.Log("Boss exiting Enraged State.");
        }
    }
}
