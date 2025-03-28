using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class UserPrivacySettingRule : Object
        {
            /// <summary>
            /// A rule to allow all of a user's contacts to do something
            /// </summary>
            public class UserPrivacySettingRuleAllowContacts : UserPrivacySettingRule
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "userPrivacySettingRuleAllowContacts";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }


            }
        }
    }
}