using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListAuditRuleRisksRequest 
    {
        /// <summary>
        /// 风险级别 - LOW - MEDIUM - HIGH - NO_RISK
        /// </summary>
        /// <value>风险级别 - LOW - MEDIUM - HIGH - NO_RISK</value>
        [JsonConverter(typeof(EnumClassConverter<RiskLevelsEnum>))]
        public class RiskLevelsEnum
        {
            /// <summary>
            /// Enum LOW for value: LOW
            /// </summary>
            public static readonly RiskLevelsEnum LOW = new RiskLevelsEnum("LOW");

            /// <summary>
            /// Enum MEDIUM for value: MEDIUM
            /// </summary>
            public static readonly RiskLevelsEnum MEDIUM = new RiskLevelsEnum("MEDIUM");

            /// <summary>
            /// Enum HIGH for value: HIGH
            /// </summary>
            public static readonly RiskLevelsEnum HIGH = new RiskLevelsEnum("HIGH");

            /// <summary>
            /// Enum NO_RISK for value: NO_RISK
            /// </summary>
            public static readonly RiskLevelsEnum NO_RISK = new RiskLevelsEnum("NO_RISK");

            private static readonly Dictionary<string, RiskLevelsEnum> StaticFields =
            new Dictionary<string, RiskLevelsEnum>()
            {
                { "LOW", LOW },
                { "MEDIUM", MEDIUM },
                { "HIGH", HIGH },
                { "NO_RISK", NO_RISK },
            };

            private string _value;

            public RiskLevelsEnum()
            {

            }

            public RiskLevelsEnum(string value)
            {
                _value = value;
            }

            public static RiskLevelsEnum FromValue(string value)
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

                if (this.Equals(obj as RiskLevelsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RiskLevelsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RiskLevelsEnum a, RiskLevelsEnum b)
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

            public static bool operator !=(RiskLevelsEnum a, RiskLevelsEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 实例ID。可通过查询实例列表接口ID字段获取 **约束限制**： 不涉及 **取值范围**： 以查询实例列表接口值为准，字符长度32-64。 **默认取值**： 不涉及 
        /// </summary>
        [SDKProperty("instance_id", IsPath = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 风险名称
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 风险级别 - LOW - MEDIUM - HIGH - NO_RISK
        /// </summary>
        [SDKProperty("risk_levels", IsQuery = true)]
        [JsonProperty("risk_levels", NullValueHandling = NullValueHandling.Ignore)]
        public RiskLevelsEnum RiskLevels { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAuditRuleRisksRequest {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  riskLevels: ").Append(RiskLevels).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAuditRuleRisksRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAuditRuleRisksRequest input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.RiskLevels != input.RiskLevels) return false;

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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.RiskLevels.GetHashCode();
                return hashCode;
            }
        }
    }
}
