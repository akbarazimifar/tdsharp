using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Describes a group call
        /// </summary>
        public partial class GroupCall : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "groupCall";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Group call identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("id")]
            public int Id { get; set; }

            /// <summary>
            /// Group call title
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("title")]
            public string Title { get; set; }

            /// <summary>
            /// Point in time (Unix timestamp) when the group call is supposed to be started by an administrator; 0 if it is already active or was ended
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("scheduled_start_date")]
            public int ScheduledStartDate { get; set; }

            /// <summary>
            /// True, if the group call is scheduled and the current user will receive a notification when the group call will start
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("enabled_start_notification")]
            public bool EnabledStartNotification { get; set; }

            /// <summary>
            /// True, if the call is active
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_active")]
            public bool IsActive { get; set; }

            /// <summary>
            /// True, if the chat is an RTMP stream instead of an ordinary video chat
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_rtmp_stream")]
            public bool IsRtmpStream { get; set; }

            /// <summary>
            /// True, if the call is joined
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_joined")]
            public bool IsJoined { get; set; }

            /// <summary>
            /// True, if user was kicked from the call because of network loss and the call needs to be rejoined
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("need_rejoin")]
            public bool NeedRejoin { get; set; }

            /// <summary>
            /// True, if the current user can manage the group call
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_be_managed")]
            public bool CanBeManaged { get; set; }

            /// <summary>
            /// Number of participants in the group call
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("participant_count")]
            public int ParticipantCount { get; set; }

            /// <summary>
            /// True, if group call participants, which are muted, aren't returned in participant list
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("has_hidden_listeners")]
            public bool HasHiddenListeners { get; set; }

            /// <summary>
            /// True, if all group call participants are loaded
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("loaded_all_participants")]
            public bool LoadedAllParticipants { get; set; }

            /// <summary>
            /// At most 3 recently speaking users in the group call
            /// </summary>
            [JsonProperty("recent_speakers", ItemConverterType = typeof(Converter))]
            public GroupCallRecentSpeaker[] RecentSpeakers { get; set; }

            /// <summary>
            /// True, if the current user's video is enabled
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_my_video_enabled")]
            public bool IsMyVideoEnabled { get; set; }

            /// <summary>
            /// True, if the current user's video is paused
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_my_video_paused")]
            public bool IsMyVideoPaused { get; set; }

            /// <summary>
            /// True, if the current user can broadcast video or share screen
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_enable_video")]
            public bool CanEnableVideo { get; set; }

            /// <summary>
            /// True, if only group call administrators can unmute new participants
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("mute_new_participants")]
            public bool MuteNewParticipants { get; set; }

            /// <summary>
            /// True, if the current user can enable or disable mute_new_participants setting
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_toggle_mute_new_participants")]
            public bool CanToggleMuteNewParticipants { get; set; }

            /// <summary>
            /// Duration of the ongoing group call recording, in seconds; 0 if none. An updateGroupCall update is not triggered when value of this field changes, but the same recording goes on
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("record_duration")]
            public int RecordDuration { get; set; }

            /// <summary>
            /// True, if a video file is being recorded for the call
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_video_recorded")]
            public bool IsVideoRecorded { get; set; }

            /// <summary>
            /// Call duration, in seconds; for ended calls only
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("duration")]
            public int Duration { get; set; }
        }
    }
}