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
        /// Invites users to an active group call. Sends a service message of type messageInviteToGroupCall for video chats
        /// </summary>
        public class InviteGroupCallParticipants : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "inviteGroupCallParticipants";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Group call identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("group_call_id")]
            public int GroupCallId { get; set; }

            /// <summary>
            /// User identifiers. At most 10 users can be invited simultaneously
            /// </summary>
            [JsonProperty("user_ids", ItemConverterType = typeof(Converter))]
            public long[] UserIds { get; set; }
        }

        /// <summary>
        /// Invites users to an active group call. Sends a service message of type messageInviteToGroupCall for video chats
        /// </summary>
        public static Task<Ok> InviteGroupCallParticipantsAsync(
            this Client client, int groupCallId = default, long[] userIds = default)
        {
            return client.ExecuteAsync(new InviteGroupCallParticipants
            {
                GroupCallId = groupCallId, UserIds = userIds
            });
        }
    }
}