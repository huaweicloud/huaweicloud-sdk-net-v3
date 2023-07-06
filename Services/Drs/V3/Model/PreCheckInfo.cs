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
    /// 预检查信息体
    /// </summary>
    public class PreCheckInfo 
    {
        /// <summary>
        /// 预检查模式
        /// </summary>
        /// <value>预检查模式</value>
        [JsonConverter(typeof(EnumClassConverter<PrecheckModeEnum>))]
        public class PrecheckModeEnum
        {
            /// <summary>
            /// Enum FORSTARTJOB for value: forStartJob
            /// </summary>
            public static readonly PrecheckModeEnum FORSTARTJOB = new PrecheckModeEnum("forStartJob");

            /// <summary>
            /// Enum FORRETRYJOB for value: forRetryJob
            /// </summary>
            public static readonly PrecheckModeEnum FORRETRYJOB = new PrecheckModeEnum("forRetryJob");

            private static readonly Dictionary<string, PrecheckModeEnum> StaticFields =
            new Dictionary<string, PrecheckModeEnum>()
            {
                { "forStartJob", FORSTARTJOB },
                { "forRetryJob", FORRETRYJOB },
            };

            private string _value;

            public PrecheckModeEnum()
            {

            }

            public PrecheckModeEnum(string value)
            {
                _value = value;
            }

            public static PrecheckModeEnum FromValue(string value)
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

                if (this.Equals(obj as PrecheckModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PrecheckModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PrecheckModeEnum a, PrecheckModeEnum b)
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

            public static bool operator !=(PrecheckModeEnum a, PrecheckModeEnum b)
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
        /// 预检查模式
        /// </summary>
        [JsonProperty("precheck_mode", NullValueHandling = NullValueHandling.Ignore)]
        public PrecheckModeEnum PrecheckMode { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PreCheckInfo {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  precheckMode: ").Append(PrecheckMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PreCheckInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PreCheckInfo input)
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
                    this.PrecheckMode == input.PrecheckMode ||
                    (this.PrecheckMode != null &&
                    this.PrecheckMode.Equals(input.PrecheckMode))
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
                if (this.PrecheckMode != null)
                    hashCode = hashCode * 59 + this.PrecheckMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
