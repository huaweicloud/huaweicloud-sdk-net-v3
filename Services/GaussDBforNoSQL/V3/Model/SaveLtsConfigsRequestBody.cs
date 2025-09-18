using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SaveLtsConfigsRequestBody 
    {
        /// <summary>
        /// 日志类型。slow_log表示慢日志。
        /// </summary>
        /// <value>日志类型。slow_log表示慢日志。</value>
        [JsonConverter(typeof(EnumClassConverter<LogTypeEnum>))]
        public class LogTypeEnum
        {
            /// <summary>
            /// Enum SLOW_LOG for value: slow_log
            /// </summary>
            public static readonly LogTypeEnum SLOW_LOG = new LogTypeEnum("slow_log");

            private static readonly Dictionary<string, LogTypeEnum> StaticFields =
            new Dictionary<string, LogTypeEnum>()
            {
                { "slow_log", SLOW_LOG },
            };

            private string _value;

            public LogTypeEnum()
            {

            }

            public LogTypeEnum(string value)
            {
                _value = value;
            }

            public static LogTypeEnum FromValue(string value)
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

                if (this.Equals(obj as LogTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LogTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LogTypeEnum a, LogTypeEnum b)
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

            public static bool operator !=(LogTypeEnum a, LogTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 需要建立关联的实例ID列表。
        /// </summary>
        [JsonProperty("instance_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// 日志类型。slow_log表示慢日志。
        /// </summary>
        [JsonProperty("log_type", NullValueHandling = NullValueHandling.Ignore)]
        public LogTypeEnum LogType { get; set; }
        /// <summary>
        /// LTS日志组ID。可通过云日志服务-“查询账号下所有日志组”API接口获取。
        /// </summary>
        [JsonProperty("lts_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LtsGroupId { get; set; }

        /// <summary>
        /// LTS日志流ID。可通过云日志服务-“查询指定日志组下的所有日志流”API接口获取。
        /// </summary>
        [JsonProperty("lts_stream_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LtsStreamId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SaveLtsConfigsRequestBody {\n");
            sb.Append("  instanceIds: ").Append(InstanceIds).Append("\n");
            sb.Append("  logType: ").Append(LogType).Append("\n");
            sb.Append("  ltsGroupId: ").Append(LtsGroupId).Append("\n");
            sb.Append("  ltsStreamId: ").Append(LtsStreamId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SaveLtsConfigsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SaveLtsConfigsRequestBody input)
        {
            if (input == null) return false;
            if (this.InstanceIds != input.InstanceIds || (this.InstanceIds != null && input.InstanceIds != null && !this.InstanceIds.SequenceEqual(input.InstanceIds))) return false;
            if (this.LogType != input.LogType) return false;
            if (this.LtsGroupId != input.LtsGroupId || (this.LtsGroupId != null && !this.LtsGroupId.Equals(input.LtsGroupId))) return false;
            if (this.LtsStreamId != input.LtsStreamId || (this.LtsStreamId != null && !this.LtsStreamId.Equals(input.LtsStreamId))) return false;

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
                if (this.InstanceIds != null) hashCode = hashCode * 59 + this.InstanceIds.GetHashCode();
                hashCode = hashCode * 59 + this.LogType.GetHashCode();
                if (this.LtsGroupId != null) hashCode = hashCode * 59 + this.LtsGroupId.GetHashCode();
                if (this.LtsStreamId != null) hashCode = hashCode * 59 + this.LtsStreamId.GetHashCode();
                return hashCode;
            }
        }
    }
}
