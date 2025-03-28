using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class CallState : Object
        {
            /// <summary>
            /// The call has ended successfully
            /// </summary>
            public class CallStateDiscarded : CallState
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "callStateDiscarded";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// The reason, why the call has ended
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("reason")]
                public CallDiscardReason Reason { get; set; }

                /// <summary>
                /// True, if the call rating must be sent to the server
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("need_rating")]
                public bool NeedRating { get; set; }

                /// <summary>
                /// True, if the call debug information must be sent to the server
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("need_debug_information")]
                public bool NeedDebugInformation { get; set; }

                /// <summary>
                /// True, if the call log must be sent to the server
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("need_log")]
                public bool NeedLog { get; set; }
            }
        }
    }
}