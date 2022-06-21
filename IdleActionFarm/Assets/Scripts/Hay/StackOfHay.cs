using DG.Tweening;
using UnityEngine;

namespace Hay
{
    public class StackOfHay : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
        }

        public void JumpTo(Vector3 poit)
        {
            transform.DOJump(poit, 10f, 1, 1f);
        }
    }
}