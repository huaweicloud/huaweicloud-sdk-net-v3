using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UpdateLogStreamResponse : SdkResponse
    {
        /// <summary>
        /// 日志存储时间（天）。
        /// </summary>
        /// <value>日志存储时间（天）。</value>
        [JsonConverter(typeof(EnumClassConverter<TtlInDaysEnum>))]
        public class TtlInDaysEnum
        {
            /// <summary>
            /// Enum NUMBER_7 for value: 7
            /// </summary>
            public static readonly TtlInDaysEnum NUMBER_7 = new TtlInDaysEnum(7);

            private static readonly Dictionary<int?, TtlInDaysEnum> StaticFields =
            new Dictionary<int?, TtlInDaysEnum>()
            {
                { 7, NUMBER_7 },
            };

            private int? _value;

            public TtlInDaysEnum()
            {

            }

            public TtlInDaysEnum(int? value)
            {
                _value = value;
            }

            public static TtlInDaysEnum FromValue(int? value)
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

            public int? GetValue()
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

                if (this.Equals(obj as TtlInDaysEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TtlInDaysEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TtlInDaysEnum a, TtlInDaysEnum b)
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

            public static bool operator !=(TtlInDaysEnum a, TtlInDaysEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 创建该日志流的时间
        /// </summary>
        [JsonProperty("creation_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreationTime { get; set; }

        /// <summary>
        /// 日志流的名称。
        /// </summary>
        [JsonProperty("log_topic_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogTopicName { get; set; }

        /// <summary>
        /// 日志流ID。
        /// </summary>
        [JsonProperty("log_topic_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogTopicId { get; set; }

        /// <summary>
        /// 日志存储时间（天）。
        /// </summary>
        [JsonProperty("ttl_in_days", NullValueHandling = NullValueHandling.Ignore)]
        public TtlInDaysEnum TtlInDays { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateLogStreamResponse {\n");
            sb.Append("  creationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  logTopicName: ").Append(LogTopicName).Append("\n");
            sb.Append("  logTopicId: ").Append(LogTopicId).Append("\n");
            sb.Append("  ttlInDays: ").Append(TtlInDays).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateLogStreamResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateLogStreamResponse input)
        {
            if (input == null) return false;
            if (this.CreationTime != input.CreationTime || (this.CreationTime != null && !this.CreationTime.Equals(input.CreationTime))) return false;
            if (this.LogTopicName != input.LogTopicName || (this.LogTopicName != null && !this.LogTopicName.Equals(input.LogTopicName))) return false;
            if (this.LogTopicId != input.LogTopicId || (this.LogTopicId != null && !this.LogTopicId.Equals(input.LogTopicId))) return false;
            if (this.TtlInDays != input.TtlInDays) return false;

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
                if (this.CreationTime != null) hashCode = hashCode * 59 + this.CreationTime.GetHashCode();
                if (this.LogTopicName != null) hashCode = hashCode * 59 + this.LogTopicName.GetHashCode();
                if (this.LogTopicId != null) hashCode = hashCode * 59 + this.LogTopicId.GetHashCode();
                hashCode = hashCode * 59 + this.TtlInDays.GetHashCode();
                return hashCode;
            }
        }
    }
}
