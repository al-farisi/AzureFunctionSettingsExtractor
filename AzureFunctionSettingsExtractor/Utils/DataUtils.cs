using AzureFunctionSettingsExtractor.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AzureFunctionSettingsExtractor.Utils
{
    public static class DataUtils
    {
        public static List<SettingModel> ExtractSetting(string jsonStr)
        {
            dynamic data = JsonConvert.DeserializeObject(jsonStr);

            var result = new List<SettingModel>();
            foreach (var item in data)
            {
                if (item.Name == "Values")
                {
                    var values = item.Value;
                    foreach (var val in values)
                    {
                        var setting = new SettingModel()
                        {
                            Name = val.Name,
                            Value = val.Value,
                            SlotSetting = false
                        };

                        result.Add(setting);
                    }
                }
            }

            return result;
        }
    }
}
