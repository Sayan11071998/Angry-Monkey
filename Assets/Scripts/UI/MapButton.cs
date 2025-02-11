using UnityEngine;
using UnityEngine.UI;
using ServiceLocator.Events;

namespace ServiceLocator.UI
{
    public class MapButton : MonoBehaviour
    {
        [SerializeField] private int MapId;
        private EventService eventService;

        public void Init(EventService eventService)
        {
            this.eventService = eventService;
            int unlockedMapID = PlayerPrefs.GetInt("UnlockedMapID", 1);

            Button button = GetComponent<Button>();
            bool isUnlocked = MapId <= unlockedMapID;

            button.interactable = isUnlocked;

            if (!isUnlocked)
            {
                GetComponentInChildren<Text>().text += " (Locked)";
            }

            button.onClick.AddListener(OnMapButtonClicked);
        }

        private void OnMapButtonClicked() => eventService.OnMapSelected.InvokeEvent(MapId);
    }
}