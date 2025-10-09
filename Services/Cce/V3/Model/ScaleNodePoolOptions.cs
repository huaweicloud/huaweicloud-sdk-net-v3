using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 节点池伸缩选项配置
    /// </summary>
    public class ScaleNodePoolOptions 
    {
        /// <summary>
        /// **参数解释**： 扩容的策略，允许为空，该参数scaleGroups传多项时有效。 **约束限制**： 不涉及 **取值范围**： - AZBalance：AZ优先策略，扩容节点池时，系统会使各个AZ间的节点数尽可能的均衡，规格会在所选伸缩组中随机指定。该策略适用于对节点成本和可用区无特殊要求的场景，优点是配置简便、降低单点故障风险。注意：如果某个AZ资源不足，该AZ期望的扩容节点会向其他AZ扩容，可能会使AZ间节点不均衡。如需解决该问题，可在该AZ资源充足时尝试再次扩容。 - Random：随机策略，从下发的规格scaleGroups列表中随机选择伸缩组扩容。  **默认取值**： Random 
        /// </summary>
        /// <value>**参数解释**： 扩容的策略，允许为空，该参数scaleGroups传多项时有效。 **约束限制**： 不涉及 **取值范围**： - AZBalance：AZ优先策略，扩容节点池时，系统会使各个AZ间的节点数尽可能的均衡，规格会在所选伸缩组中随机指定。该策略适用于对节点成本和可用区无特殊要求的场景，优点是配置简便、降低单点故障风险。注意：如果某个AZ资源不足，该AZ期望的扩容节点会向其他AZ扩容，可能会使AZ间节点不均衡。如需解决该问题，可在该AZ资源充足时尝试再次扩容。 - Random：随机策略，从下发的规格scaleGroups列表中随机选择伸缩组扩容。  **默认取值**： Random </value>
        [JsonConverter(typeof(EnumClassConverter<ScalePolicyEnum>))]
        public class ScalePolicyEnum
        {
            /// <summary>
            /// Enum AZBALANCE for value: AZBalance
            /// </summary>
            public static readonly ScalePolicyEnum AZBALANCE = new ScalePolicyEnum("AZBalance");

            /// <summary>
            /// Enum RANDOM for value: Random
            /// </summary>
            public static readonly ScalePolicyEnum RANDOM = new ScalePolicyEnum("Random");

            private static readonly Dictionary<string, ScalePolicyEnum> StaticFields =
            new Dictionary<string, ScalePolicyEnum>()
            {
                { "AZBalance", AZBALANCE },
                { "Random", RANDOM },
            };

            private string _value;

            public ScalePolicyEnum()
            {

            }

            public ScalePolicyEnum(string value)
            {
                _value = value;
            }

            public static ScalePolicyEnum FromValue(string value)
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

                if (this.Equals(obj as ScalePolicyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ScalePolicyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ScalePolicyEnum a, ScalePolicyEnum b)
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

            public static bool operator !=(ScalePolicyEnum a, ScalePolicyEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 扩容状态检查策略: instant(同步检查), async(异步检查)。默认同步检查instant 
        /// </summary>
        [JsonProperty("scalableChecking", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalableChecking { get; set; }

        /// <summary>
        /// **参数解释**： 扩容的策略，允许为空，该参数scaleGroups传多项时有效。 **约束限制**： 不涉及 **取值范围**： - AZBalance：AZ优先策略，扩容节点池时，系统会使各个AZ间的节点数尽可能的均衡，规格会在所选伸缩组中随机指定。该策略适用于对节点成本和可用区无特殊要求的场景，优点是配置简便、降低单点故障风险。注意：如果某个AZ资源不足，该AZ期望的扩容节点会向其他AZ扩容，可能会使AZ间节点不均衡。如需解决该问题，可在该AZ资源充足时尝试再次扩容。 - Random：随机策略，从下发的规格scaleGroups列表中随机选择伸缩组扩容。  **默认取值**： Random 
        /// </summary>
        [JsonProperty("scalePolicy", NullValueHandling = NullValueHandling.Ignore)]
        public ScalePolicyEnum ScalePolicy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("billingConfigOverride", NullValueHandling = NullValueHandling.Ignore)]
        public ScaleUpBillingConfigOverride BillingConfigOverride { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScaleNodePoolOptions {\n");
            sb.Append("  scalableChecking: ").Append(ScalableChecking).Append("\n");
            sb.Append("  scalePolicy: ").Append(ScalePolicy).Append("\n");
            sb.Append("  billingConfigOverride: ").Append(BillingConfigOverride).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScaleNodePoolOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScaleNodePoolOptions input)
        {
            if (input == null) return false;
            if (this.ScalableChecking != input.ScalableChecking || (this.ScalableChecking != null && !this.ScalableChecking.Equals(input.ScalableChecking))) return false;
            if (this.ScalePolicy != input.ScalePolicy) return false;
            if (this.BillingConfigOverride != input.BillingConfigOverride || (this.BillingConfigOverride != null && !this.BillingConfigOverride.Equals(input.BillingConfigOverride))) return false;

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
                if (this.ScalableChecking != null) hashCode = hashCode * 59 + this.ScalableChecking.GetHashCode();
                hashCode = hashCode * 59 + this.ScalePolicy.GetHashCode();
                if (this.BillingConfigOverride != null) hashCode = hashCode * 59 + this.BillingConfigOverride.GetHashCode();
                return hashCode;
            }
        }
    }
}
