using UnityEngine;
using UnityEngine.EventSystems;

namespace ApplicationLayer.Input
{
    public class InputListener : MonoBehaviour, IBeginDragHandler, IDragHandler
    {
        public void OnBeginDrag(PointerEventData eventData)
        {
            // TODO: if input is not enabled, return

            var swipeDirection = GetSwipeDirection(eventData.delta);
            Debug.Log($"Swipe Direction:{swipeDirection}");
        }

        public void OnDrag(PointerEventData eventData)
        {
            // Nothing, but have to be implemented in order to IBeginDragHandler work
        }

        private static SwipeDirection GetSwipeDirection(Vector2 deltaSwipe)
        {
            var horizontalDelta = Mathf.Abs(deltaSwipe.x);
            var verticalDelta = Mathf.Abs(deltaSwipe.y);

            if (horizontalDelta > verticalDelta)
            {
                return Mathf.Sign(deltaSwipe.x) > 0
                    ? SwipeDirection.Right
                    : SwipeDirection.Left;
            }
            
            return Mathf.Sign(deltaSwipe.y) > 0
                ? SwipeDirection.Up
                : SwipeDirection.Down;
        }
    }
}