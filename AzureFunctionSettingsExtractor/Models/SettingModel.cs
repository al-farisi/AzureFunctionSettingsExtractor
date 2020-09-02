using Newtonsoft.Json;

namespace AzureFunctionSettingsExtractor.Models
{
    public class SettingModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("slotSetting")]
        public bool SlotSetting { get; set; }
    }
}
