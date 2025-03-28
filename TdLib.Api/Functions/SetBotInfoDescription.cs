using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Sets the text shown in the chat with the bot if the chat is empty; bots only
        /// </summary>
        public class SetBotInfoDescription : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setBotInfoDescription";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// A two-letter ISO 639-1 language code. If empty, the description will be shown to all users, for which language there are no dedicated description
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("language_code")]
            public string LanguageCode { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("description")]
            public string Description { get; set; }
        }

        /// <summary>
        /// Sets the text shown in the chat with the bot if the chat is empty; bots only
        /// </summary>
        public static Task<Ok> SetBotInfoDescriptionAsync(
            this Client client, string languageCode = default, string description = default)
        {
            return client.ExecuteAsync(new SetBotInfoDescription
            {
                LanguageCode = languageCode, Description = description
            });
        }
    }
}