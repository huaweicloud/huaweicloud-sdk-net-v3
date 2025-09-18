using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class SearchQosParticipantDetailRequest 
    {
        /// <summary>
        /// 会议类别。 * online：在线会议，在召开的会议 * history：历史会议，已召开的会议
        /// </summary>
        /// <value>会议类别。 * online：在线会议，在召开的会议 * history：历史会议，已召开的会议</value>
        [JsonConverter(typeof(EnumClassConverter<ConfTypeEnum>))]
        public class ConfTypeEnum
        {
            /// <summary>
            /// Enum ONLINE for value: online
            /// </summary>
            public static readonly ConfTypeEnum ONLINE = new ConfTypeEnum("online");

            /// <summary>
            /// Enum HISTORY for value: history
            /// </summary>
            public static readonly ConfTypeEnum HISTORY = new ConfTypeEnum("history");

            private static readonly Dictionary<string, ConfTypeEnum> StaticFields =
            new Dictionary<string, ConfTypeEnum>()
            {
                { "online", ONLINE },
                { "history", HISTORY },
            };

            private string _value;

            public ConfTypeEnum()
            {

            }

            public ConfTypeEnum(string value)
            {
                _value = value;
            }

            public static ConfTypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as ConfTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ConfTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ConfTypeEnum a, ConfTypeEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ConfTypeEnum a, ConfTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Qos类型。 - audio：音频 - video：视频 - screen：屏幕共享 - cpu：cpu
        /// </summary>
        /// <value>Qos类型。 - audio：音频 - video：视频 - screen：屏幕共享 - cpu：cpu</value>
        [JsonConverter(typeof(EnumClassConverter<QosTypeEnum>))]
        public class QosTypeEnum
        {
            /// <summary>
            /// Enum AUDIO for value: audio
            /// </summary>
            public static readonly QosTypeEnum AUDIO = new QosTypeEnum("audio");

            /// <summary>
            /// Enum VIDEO for value: video
            /// </summary>
            public static readonly QosTypeEnum VIDEO = new QosTypeEnum("video");

            /// <summary>
            /// Enum SCREEN for value: screen
            /// </summary>
            public static readonly QosTypeEnum SCREEN = new QosTypeEnum("screen");

            /// <summary>
            /// Enum CPU for value: cpu
            /// </summary>
            public static readonly QosTypeEnum CPU = new QosTypeEnum("cpu");

            private static readonly Dictionary<string, QosTypeEnum> StaticFields =
            new Dictionary<string, QosTypeEnum>()
            {
                { "audio", AUDIO },
                { "video", VIDEO },
                { "screen", SCREEN },
                { "cpu", CPU },
            };

            private string _value;

            public QosTypeEnum()
            {

            }

            public QosTypeEnum(string value)
            {
                _value = value;
            }

            public static QosTypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as QosTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(QosTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(QosTypeEnum a, QosTypeEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(QosTypeEnum a, QosTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 会议UUID。
        /// </summary>
        [SDKProperty("confUUID", IsQuery = true)]
        [JsonProperty("confUUID", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfUUID { get; set; }

        /// <summary>
        /// 会议类别。 * online：在线会议，在召开的会议 * history：历史会议，已召开的会议
        /// </summary>
        [SDKProperty("confType", IsQuery = true)]
        [JsonProperty("confType", NullValueHandling = NullValueHandling.Ignore)]
        public ConfTypeEnum ConfType { get; set; }
        /// <summary>
        /// 与会者标识。
        /// </summary>
        [SDKProperty("participantID", IsQuery = true)]
        [JsonProperty("participantID", NullValueHandling = NullValueHandling.Ignore)]
        public string ParticipantID { get; set; }

        /// <summary>
        /// Qos类型。 - audio：音频 - video：视频 - screen：屏幕共享 - cpu：cpu
        /// </summary>
        [SDKProperty("qosType", IsQuery = true)]
        [JsonProperty("qosType", NullValueHandling = NullValueHandling.Ignore)]
        public QosTypeEnum QosType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchQosParticipantDetailRequest {\n");
            sb.Append("  confUUID: ").Append(ConfUUID).Append("\n");
            sb.Append("  confType: ").Append(ConfType).Append("\n");
            sb.Append("  participantID: ").Append(ParticipantID).Append("\n");
            sb.Append("  qosType: ").Append(QosType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchQosParticipantDetailRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchQosParticipantDetailRequest input)
        {
            if (input == null) return false;
            if (this.ConfUUID != input.ConfUUID || (this.ConfUUID != null && !this.ConfUUID.Equals(input.ConfUUID))) return false;
            if (this.ConfType != input.ConfType) return false;
            if (this.ParticipantID != input.ParticipantID || (this.ParticipantID != null && !this.ParticipantID.Equals(input.ParticipantID))) return false;
            if (this.QosType != input.QosType) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.ConfUUID != null) hashCode = hashCode * 59 + this.ConfUUID.GetHashCode();
                hashCode = hashCode * 59 + this.ConfType.GetHashCode();
                if (this.ParticipantID != null) hashCode = hashCode * 59 + this.ParticipantID.GetHashCode();
                hashCode = hashCode * 59 + this.QosType.GetHashCode();
                return hashCode;
            }
        }
    }
}
