using UnityEngine;
using UnityEngine.UI;
using ServiceLocator.Events;
using TMPro;

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

            if (button == null)
            {
                Debug.LogError($"Button component is missing on GameObject: {gameObject.name}");
                return;
            }

            bool isUnlocked = MapId <= unlockedMapID;

            button.interactable = isUnlocked;

            if (!isUnlocked)
            {
                GetComponentInChildren<TextMeshProUGUI>().text += " (Locked)";
                // var local = GetComponentInChildren<TextMeshProUGUI>();

                // if (local == null)
                // {
                //     Debug.Log("Not able to find local");
                // }
                // else
                // {
                //     Debug.Log("Able to find the local");
                // }
            }

            button.onClick.AddListener(OnMapButtonClicked);
        }

        private void OnMapButtonClicked() => eventService.OnMapSelected.InvokeEvent(MapId);
    }
}