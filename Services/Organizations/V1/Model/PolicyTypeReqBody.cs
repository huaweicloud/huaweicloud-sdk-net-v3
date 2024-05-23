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
    /// 策略类型相关操作的请求体。
    /// </summary>
    public class PolicyTypeReqBody 
    {
        /// <summary>
        /// 策略类型的名称，service_control_policy服务控制策略；tag_policy：标签策略。
        /// </summary>
        /// <value>策略类型的名称，service_control_policy服务控制策略；tag_policy：标签策略。</value>
        [JsonConverter(typeof(EnumClassConverter<PolicyTypeEnum>))]
        public class PolicyTypeEnum
        {
            /// <summary>
            /// Enum SERVICE_CONTROL_POLICY for value: service_control_policy
            /// </summary>
            public static readonly PolicyTypeEnum SERVICE_CONTROL_POLICY = new PolicyTypeEnum("service_control_policy");

            /// <summary>
            /// Enum TAG_POLICY for value: tag_policy
            /// </summary>
            public static readonly PolicyTypeEnum TAG_POLICY = new PolicyTypeEnum("tag_policy");

            private static readonly Dictionary<string, PolicyTypeEnum> StaticFields =
            new Dictionary<string, PolicyTypeEnum>()
            {
                { "service_control_policy", SERVICE_CONTROL_POLICY },
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
        /// 策略类型的名称，service_control_policy服务控制策略；tag_policy：标签策略。
        /// </summary>
        [JsonProperty("policy_type", NullValueHandling = NullValueHandling.Ignore)]
        public PolicyTypeEnum PolicyType { get; set; }
        /// <summary>
        /// 根的唯一标识符（ID）。
        /// </summary>
        [JsonProperty("root_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RootId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyTypeReqBody {\n");
            sb.Append("  policyType: ").Append(PolicyType).Append("\n");
            sb.Append("  rootId: ").Append(RootId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PolicyTypeReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PolicyTypeReqBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PolicyType == input.PolicyType ||
                    (this.PolicyType != null &&
                    this.PolicyType.Equals(input.PolicyType))
                ) && 
                (
                    this.RootId == input.RootId ||
                    (this.RootId != null &&
                    this.RootId.Equals(input.RootId))
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
                if (this.PolicyType != null)
                    hashCode = hashCode * 59 + this.PolicyType.GetHashCode();
                if (this.RootId != null)
                    hashCode = hashCode * 59 + this.RootId.GetHashCode();
                return hashCode;
            }
        }
    }
}
