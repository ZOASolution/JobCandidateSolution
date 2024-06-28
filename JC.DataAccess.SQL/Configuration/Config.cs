using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JC.DataAccess.SQL.Configuration
{
    public sealed class Config
    {
        private static Config? _config;
        public static Config? Current {
            get {
                _config ??= ReadConfig();
                return _config;
            } 
        }
        [JsonProperty]
        public string ConnectionString { get; init; } = default!;
        private static Config? ReadConfig()
        {
            string configPath=Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Configuration\\Config.Json");
            string content=File.ReadAllText(configPath);
            
            Config? config=JsonConvert.DeserializeObject<Config>(content);

            return config;

        }

        private Config() { }
    }
}
