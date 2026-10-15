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
        /// **参数解释**：  预检查模式，指定执行预检查的场景类型。请按照任务对应的状态传值，否则可能导致预检查失败，影响任务启动。  **约束限制**：  不涉及。  **取值范围**：  - forStartJob：任务配置中首次启动时预检查 - forRetryJob：任务增量中编辑对象后预检查，或任务失败后重试时预检查  **默认取值**：  不涉及
        /// </summary>
        /// <value>**参数解释**：  预检查模式，指定执行预检查的场景类型。请按照任务对应的状态传值，否则可能导致预检查失败，影响任务启动。  **约束限制**：  不涉及。  **取值范围**：  - forStartJob：任务配置中首次启动时预检查 - forRetryJob：任务增量中编辑对象后预检查，或任务失败后重试时预检查  **默认取值**：  不涉及</value>
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

            public static bool operator !=(PrecheckModeEnum a, PrecheckModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**：  迁移任务ID，用于唯一标识一个数据复制任务，在查询、修改、删除等操作中作为任务的识别凭证。  **约束限制**：  不涉及。  **取值范围**：  UUID格式字符串。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// **参数解释**：  预检查模式，指定执行预检查的场景类型。请按照任务对应的状态传值，否则可能导致预检查失败，影响任务启动。  **约束限制**：  不涉及。  **取值范围**：  - forStartJob：任务配置中首次启动时预检查 - forRetryJob：任务增量中编辑对象后预检查，或任务失败后重试时预检查  **默认取值**：  不涉及
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
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.PrecheckMode != input.PrecheckMode) return false;

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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                hashCode = hashCode * 59 + this.PrecheckMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
