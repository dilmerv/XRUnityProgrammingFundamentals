using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Core
{
    public class Player
    {
        public string FullName { get; set; }

        public int Age { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public decimal Weight { get; set; }

        public override string ToString()
        {
            return $"FullName: {FullName} Age: {Age} Email: {Email}";
        }

        public int Lives { get; set; } = 5;

        public void TookHit()
        {
            Lives--;
            Debug.Log($"TookHit Lives : {Lives}");
        }

        public void TookHit(int howMany)
        {
            if (Lives - howMany >= 0)
            {
                Lives -= howMany;
                Debug.Log($"TookHit Lives : {Lives}");
            }
            else
            {
                Lives = 0;
                Debug.Log($"Game Over");
            }
        }

        public void TookHitIncremental()
        {
            Lives -= 2;
            Debug.Log($"TookHit Lives : {Lives}");
        }

        public string GetFullNameAndUsername()
        {
            return $"{FullName} {UserName}";
        }

    }
}
