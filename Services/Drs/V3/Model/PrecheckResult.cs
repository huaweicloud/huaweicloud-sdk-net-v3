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
    /// 预检查结果信息体
    /// </summary>
    public class PrecheckResult 
    {
        /// <summary>
        /// **参数解释**：  预检查项的检查结果，表示该检查项是否通过。  **约束限制**：  不涉及。  **取值范围**：  - PASSED：通过 - ALARM：告警 - FAILED：失败  **默认取值**：  不涉及
        /// </summary>
        /// <value>**参数解释**：  预检查项的检查结果，表示该检查项是否通过。  **约束限制**：  不涉及。  **取值范围**：  - PASSED：通过 - ALARM：告警 - FAILED：失败  **默认取值**：  不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<ResultEnum>))]
        public class ResultEnum
        {
            /// <summary>
            /// Enum PASSED for value: PASSED
            /// </summary>
            public static readonly ResultEnum PASSED = new ResultEnum("PASSED");

            /// <summary>
            /// Enum ALARM for value: ALARM
            /// </summary>
            public static readonly ResultEnum ALARM = new ResultEnum("ALARM");

            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            public static readonly ResultEnum FAILED = new ResultEnum("FAILED");

            private static readonly Dictionary<string, ResultEnum> StaticFields =
            new Dictionary<string, ResultEnum>()
            {
                { "PASSED", PASSED },
                { "ALARM", ALARM },
                { "FAILED", FAILED },
            };

            private string _value;

            public ResultEnum()
            {

            }

            public ResultEnum(string value)
            {
                _value = value;
            }

            public static ResultEnum FromValue(string value)
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

                if (this.Equals(obj as ResultEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ResultEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ResultEnum a, ResultEnum b)
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

            public static bool operator !=(ResultEnum a, ResultEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**：  预检查的具体检查项名称，用于标识预检查中执行的具体检查项目。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("item", NullValueHandling = NullValueHandling.Ignore)]
        public string Item { get; set; }

        /// <summary>
        /// **参数解释**：  预检查项的检查结果，表示该检查项是否通过。  **约束限制**：  不涉及。  **取值范围**：  - PASSED：通过 - ALARM：告警 - FAILED：失败  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public ResultEnum Result { get; set; }
        /// <summary>
        /// **参数解释**：  预检查项的失败原因，当检查结果为FAILED或ALARM时返回的具体失败描述。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("failed_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string FailedReason { get; set; }

        /// <summary>
        /// **参数解释**：  预检查项的加密数据，包含检查项的详细检测数据，以JSON格式加密返回。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public string Data { get; set; }

        /// <summary>
        /// **参数解释**：  原始错误信息，预检查过程中产生的原始错误描述。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("raw_error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string RawErrorMsg { get; set; }

        /// <summary>
        /// **参数解释**：  检查项分组，用于将预检查项按类别归类展示。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public string Group { get; set; }

        /// <summary>
        /// **参数解释**：  失败的子任务信息集合，包含预检查中失败的子任务详情，详情请参见PrecheckFailSubJobVO对象定义。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("failed_sub_jobs", NullValueHandling = NullValueHandling.Ignore)]
        public List<PrecheckFailSubJobVO> FailedSubJobs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrecheckResult {\n");
            sb.Append("  item: ").Append(Item).Append("\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("  failedReason: ").Append(FailedReason).Append("\n");
            sb.Append("  data: ").Append(Data).Append("\n");
            sb.Append("  rawErrorMsg: ").Append(RawErrorMsg).Append("\n");
            sb.Append("  group: ").Append(Group).Append("\n");
            sb.Append("  failedSubJobs: ").Append(FailedSubJobs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrecheckResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PrecheckResult input)
        {
            if (input == null) return false;
            if (this.Item != input.Item || (this.Item != null && !this.Item.Equals(input.Item))) return false;
            if (this.Result != input.Result) return false;
            if (this.FailedReason != input.FailedReason || (this.FailedReason != null && !this.FailedReason.Equals(input.FailedReason))) return false;
            if (this.Data != input.Data || (this.Data != null && !this.Data.Equals(input.Data))) return false;
            if (this.RawErrorMsg != input.RawErrorMsg || (this.RawErrorMsg != null && !this.RawErrorMsg.Equals(input.RawErrorMsg))) return false;
            if (this.Group != input.Group || (this.Group != null && !this.Group.Equals(input.Group))) return false;
            if (this.FailedSubJobs != input.FailedSubJobs || (this.FailedSubJobs != null && input.FailedSubJobs != null && !this.FailedSubJobs.SequenceEqual(input.FailedSubJobs))) return false;

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
                if (this.Item != null) hashCode = hashCode * 59 + this.Item.GetHashCode();
                hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.FailedReason != null) hashCode = hashCode * 59 + this.FailedReason.GetHashCode();
                if (this.Data != null) hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.RawErrorMsg != null) hashCode = hashCode * 59 + this.RawErrorMsg.GetHashCode();
                if (this.Group != null) hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.FailedSubJobs != null) hashCode = hashCode * 59 + this.FailedSubJobs.GetHashCode();
                return hashCode;
            }
        }
    }
}
