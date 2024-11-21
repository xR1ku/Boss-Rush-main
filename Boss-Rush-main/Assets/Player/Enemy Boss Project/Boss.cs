using UnityEngine;

namespace BossFight
{
    public class Boss : MonoBehaviour
    {
        public float health = 100f;
        public BossState currentState;

        // State references
        private BossState initialState;
        private BossState midBattleState;
        private BossState enragedState;

        private void Start()
        {
            // Initialize the states
            initialState = new InitialState(this);
            midBattleState = new MidBattleState(this);
            enragedState = new EnragedState(this);

            // Start in the Initial State
            SetState(initialState);
        }

        private void Update()
        {
            // Update the current state
            currentState?.Update();
        }

        public void SetState(BossState newState)
        {
            currentState?.Exit();
            currentState = newState;
            currentState?.Enter();
        }

        public void TakeDamage(float damage)
        {
            health -= damage;

            if (health <= 30 && currentState != enragedState)
            {
                SetState(enragedState);
            }
            else if (health <= 60 && currentState != midBattleState)
            {
                SetState(midBattleState);
            }
        }

        // Example attack methods
        public void MeleeAttack() { Debug.Log("Boss performs a melee attack!"); }
        public void RangedAttack() { Debug.Log("Boss performs a ranged attack!"); }
        public void UltimateAttack() { Debug.Log("Boss performs an ultimate attack!"); }
    }
}
