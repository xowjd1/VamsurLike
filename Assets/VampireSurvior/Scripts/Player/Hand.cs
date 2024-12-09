using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Goldmetal.UndeadSurvivor
{
    public class Hand : MonoBehaviour
    {
        public bool isLeft;
        public SpriteRenderer spriter;

        SpriteRenderer player;

        Vector3 rightPos = new Vector3(0.35f, -0.15f, 0);
        Vector3 rightPosReverse = new Vector3(-0.35f, -0.15f, 0);
        Vector3 rightScale = new Vector3(2, 2, 1);
        Vector3 leftScale = new Vector3(3, 3, 1);
        Quaternion leftRot = Quaternion.Euler(0, 0, -75);
        Quaternion leftRotReverse = Quaternion.Euler(0, 0, -100);

        void Awake()
        {
            player = GetComponentsInParent<SpriteRenderer>()[1];
        }

        void LateUpdate()
        {
            bool isReverse = player.flipX;

            if (isLeft) { // 근접무기
                transform.localRotation = isReverse ? leftRotReverse : leftRot;
                spriter.flipY = isReverse;
                transform.localScale = leftScale;
               // spriter.sortingOrder = isReverse ? 4 : 6;
            }
            else { // 원거리무기
                transform.localPosition = isReverse ? rightPosReverse : rightPos;
                spriter.flipX = isReverse;
                transform.localScale = rightScale;
               // spriter.sortingOrder = isReverse ? 6 : 4;
            }
        }
    }
}
