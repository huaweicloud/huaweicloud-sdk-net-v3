using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 暂停任务请求参数
    /// </summary>
    public class PauseInfo 
    {
        /// <summary>
        /// 暂停类型，target:停回放,all:停日志抓取和回放
        /// </summary>
        /// <value>暂停类型，target:停回放,all:停日志抓取和回放</value>
        [JsonConverter(typeof(EnumClassConverter<PauseModeEnum>))]
        public class PauseModeEnum
        {
            /// <summary>
            /// Enum TARGET for value: target
            /// </summary>
            public static readonly PauseModeEnum TARGET = new PauseModeEnum("target");

            /// <summary>
            /// Enum ALL for value: all
            /// </summary>
            public static readonly PauseModeEnum ALL = new PauseModeEnum("all");

            private static readonly Dictionary<string, PauseModeEnum> StaticFields =
            new Dictionary<string, PauseModeEnum>()
            {
                { "target", TARGET },
                { "all", ALL },
            };

            private string _value;

            public PauseModeEnum()
            {

            }

            public PauseModeEnum(string value)
            {
                _value = value;
            }

            public static PauseModeEnum FromValue(string value)
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

                if (this.Equals(obj as PauseModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PauseModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PauseModeEnum a, PauseModeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(PauseModeEnum a, PauseModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 暂停类型，target:停回放,all:停日志抓取和回放
        /// </summary>
        [JsonProperty("pause_mode", NullValueHandling = NullValueHandling.Ignore)]
        public PauseModeEnum PauseMode { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PauseInfo {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  pauseMode: ").Append(PauseMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PauseInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PauseInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.PauseMode == input.PauseMode ||
                    (this.PauseMode != null &&
                    this.PauseMode.Equals(input.PauseMode))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.PauseMode != null)
                    hashCode = hashCode * 59 + this.PauseMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
