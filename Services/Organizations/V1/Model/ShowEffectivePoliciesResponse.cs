using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Organizations.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowEffectivePoliciesResponse : SdkResponse
    {
        /// <summary>
        /// 策略类型的名称。tag_policy标签策略。
        /// </summary>
        /// <value>策略类型的名称。tag_policy标签策略。</value>
        [JsonConverter(typeof(EnumClassConverter<PolicyTypeEnum>))]
        public class PolicyTypeEnum
        {
            /// <summary>
            /// Enum TAG_POLICY for value: tag_policy
            /// </summary>
            public static readonly PolicyTypeEnum TAG_POLICY = new PolicyTypeEnum("tag_policy");

            private static readonly Dictionary<string, PolicyTypeEnum> StaticFields =
            new Dictionary<string, PolicyTypeEnum>()
            {
                { "tag_policy", TAG_POLICY },
            };

            private string _value;

            public PolicyTypeEnum()
            {

            }

            public PolicyTypeEnum(string value)
            {
                _value = value;
            }

            public static PolicyTypeEnum FromValue(string value)
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

                if (this.Equals(obj as PolicyTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PolicyTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PolicyTypeEnum a, PolicyTypeEnum b)
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

            public static bool operator !=(PolicyTypeEnum a, PolicyTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 有效策略最后更新时间。
        /// </summary>
        [JsonProperty("last_updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// 有效策略文本内容。
        /// </summary>
        [JsonProperty("policy_content", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyContent { get; set; }

        /// <summary>
        /// 策略类型的名称。tag_policy标签策略。
        /// </summary>
        [JsonProperty("policy_type", NullValueHandling = NullValueHandling.Ignore)]
        public PolicyTypeEnum PolicyType { get; set; }
        /// <summary>
        /// 根、组织单元或账号的唯一标识符（ID）。
        /// </summary>
        [JsonProperty("entity_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EntityId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowEffectivePoliciesResponse {\n");
            sb.Append("  lastUpdatedAt: ").Append(LastUpdatedAt).Append("\n");
            sb.Append("  policyContent: ").Append(PolicyContent).Append("\n");
            sb.Append("  policyType: ").Append(PolicyType).Append("\n");
            sb.Append("  entityId: ").Append(EntityId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowEffectivePoliciesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowEffectivePoliciesResponse input)
        {
            if (input == null) return false;
            if (this.LastUpdatedAt != input.LastUpdatedAt || (this.LastUpdatedAt != null && !this.LastUpdatedAt.Equals(input.LastUpdatedAt))) return false;
            if (this.PolicyContent != input.PolicyContent || (this.PolicyContent != null && !this.PolicyContent.Equals(input.PolicyContent))) return false;
            if (this.PolicyType != input.PolicyType) return false;
            if (this.EntityId != input.EntityId || (this.EntityId != null && !this.EntityId.Equals(input.EntityId))) return false;

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
                if (this.LastUpdatedAt != null) hashCode = hashCode * 59 + this.LastUpdatedAt.GetHashCode();
                if (this.PolicyContent != null) hashCode = hashCode * 59 + this.PolicyContent.GetHashCode();
                hashCode = hashCode * 59 + this.PolicyType.GetHashCode();
                if (this.EntityId != null) hashCode = hashCode * 59 + this.EntityId.GetHashCode();
                return hashCode;
            }
        }
    }
}
