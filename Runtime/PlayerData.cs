using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CustumPackage
{
    [CreateAssetMenu(fileName = "NewPlayerData", menuName = "Player Data")]
    public class PlayerData : ScriptableObject
    {


        [SerializeField]
        private string m_PlayerName;
        public string Player => m_PlayerName;

        [SerializeField]
        private int m_score = 0;
        public int score => m_score;

    }
}
