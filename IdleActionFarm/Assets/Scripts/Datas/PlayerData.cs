using UnityEngine;

namespace Datas
{
    [CreateAssetMenu(fileName = "PlayerSettings", menuName = "Data/PlayerSettings")]
    public class PlayerData : ScriptableObject
    {
        [SerializeField] private float _speed;


        public float Speed => _speed;
    }
}