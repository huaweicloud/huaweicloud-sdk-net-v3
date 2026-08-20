using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// **参数解释**: 部署方案变更请求体。 **约束限制**: 不涉及。
    /// </summary>
    public class ChangeDeploymentSolutionRequestBody 
    {
        /// <summary>
        /// **参数解释**: 变更后的目标部署形态。 **约束限制**: 必填。取值需为当前实例允许变更的目标形态。 **取值范围**: - logger：一主一备一日志节点 - triset：一主两备三节点  **默认取值**: 不涉及。
        /// </summary>
        /// <value>**参数解释**: 变更后的目标部署形态。 **约束限制**: 必填。取值需为当前实例允许变更的目标形态。 **取值范围**: - logger：一主一备一日志节点 - triset：一主两备三节点  **默认取值**: 不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<SolutionEnum>))]
        public class SolutionEnum
        {
            /// <summary>
            /// Enum LOGGER for value: logger
            /// </summary>
            public static readonly SolutionEnum LOGGER = new SolutionEnum("logger");

            /// <summary>
            /// Enum TRISET for value: triset
            /// </summary>
            public static readonly SolutionEnum TRISET = new SolutionEnum("triset");

            private static readonly Dictionary<string, SolutionEnum> StaticFields =
            new Dictionary<string, SolutionEnum>()
            {
                { "logger", LOGGER },
                { "triset", TRISET },
            };

            private string _value;

            public SolutionEnum()
            {

            }

            public SolutionEnum(string value)
            {
                _value = value;
            }

            public static SolutionEnum FromValue(string value)
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

                if (this.Equals(obj as SolutionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SolutionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SolutionEnum a, SolutionEnum b)
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

            public static bool operator !=(SolutionEnum a, SolutionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**: 变更后的目标部署形态。 **约束限制**: 必填。取值需为当前实例允许变更的目标形态。 **取值范围**: - logger：一主一备一日志节点 - triset：一主两备三节点  **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("solution", NullValueHandling = NullValueHandling.Ignore)]
        public SolutionEnum Solution { get; set; }
        /// <summary>
        /// **参数解释**: 部署可用区，多个可用区以英文逗号\&quot;,\&quot;隔开。 **约束限制**: 必填。不可包含 []()^%&amp;\\\\&#39;&#x60;|\&quot;;&#x3D;?$&lt;&gt; 等特殊字符。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// **参数解释**: 主可用区。 **约束限制**: 不填时默认使用当前主可用区。 **取值范围**: 不涉及。 **默认取值**: 当前实例的主可用区。
        /// </summary>
        [JsonProperty("master_az", NullValueHandling = NullValueHandling.Ignore)]
        public string MasterAz { get; set; }

        /// <summary>
        /// **参数解释**: 日志可用区。 **约束限制**: 带日志节点的部署形态（如 logger）需要传该参数。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("logger_az", NullValueHandling = NullValueHandling.Ignore)]
        public string LoggerAz { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeDeploymentSolutionRequestBody {\n");
            sb.Append("  solution: ").Append(Solution).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  masterAz: ").Append(MasterAz).Append("\n");
            sb.Append("  loggerAz: ").Append(LoggerAz).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChangeDeploymentSolutionRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChangeDeploymentSolutionRequestBody input)
        {
            if (input == null) return false;
            if (this.Solution != input.Solution) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;
            if (this.MasterAz != input.MasterAz || (this.MasterAz != null && !this.MasterAz.Equals(input.MasterAz))) return false;
            if (this.LoggerAz != input.LoggerAz || (this.LoggerAz != null && !this.LoggerAz.Equals(input.LoggerAz))) return false;

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
                hashCode = hashCode * 59 + this.Solution.GetHashCode();
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.MasterAz != null) hashCode = hashCode * 59 + this.MasterAz.GetHashCode();
                if (this.LoggerAz != null) hashCode = hashCode * 59 + this.LoggerAz.GetHashCode();
                return hashCode;
            }
        }
    }
}
