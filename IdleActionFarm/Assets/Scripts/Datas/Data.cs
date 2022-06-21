using System.IO;
using UnityEngine;

namespace Datas
{
    [CreateAssetMenu(fileName = "Data", menuName = "Data/Data")] public class Data : ScriptableObject
    {
        [SerializeField] private string _playerDataPath;

        private PlayerData _player;

        public PlayerData Player
        {
            get
            {
                if (_player == null)
                {
                    _player = Load<PlayerData>(Path.Combine("Data", _playerDataPath));
                }

                return _player;
            }
        }


        private T Load<T>(string resourscesPath) where T : Object =>
            Resources.Load<T>(Path.ChangeExtension(resourscesPath, null));

    }
}