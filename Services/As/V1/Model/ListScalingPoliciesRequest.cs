using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListScalingPoliciesRequest 
    {
        /// <summary>
        /// 策略类型。
        /// </summary>
        /// <value>策略类型。</value>
        [JsonConverter(typeof(EnumClassConverter<ScalingPolicyTypeEnum>))]
        public class ScalingPolicyTypeEnum
        {
            /// <summary>
            /// Enum ALARM for value: ALARM
            /// </summary>
            public static readonly ScalingPolicyTypeEnum ALARM = new ScalingPolicyTypeEnum("ALARM");

            /// <summary>
            /// Enum SCHEDULED for value: SCHEDULED
            /// </summary>
            public static readonly ScalingPolicyTypeEnum SCHEDULED = new ScalingPolicyTypeEnum("SCHEDULED");

            /// <summary>
            /// Enum RECURRENCE for value: RECURRENCE
            /// </summary>
            public static readonly ScalingPolicyTypeEnum RECURRENCE = new ScalingPolicyTypeEnum("RECURRENCE");

            private static readonly Dictionary<string, ScalingPolicyTypeEnum> StaticFields =
            new Dictionary<string, ScalingPolicyTypeEnum>()
            {
                { "ALARM", ALARM },
                { "SCHEDULED", SCHEDULED },
                { "RECURRENCE", RECURRENCE },
            };

            private string _value;

            public ScalingPolicyTypeEnum()
            {

            }

            public ScalingPolicyTypeEnum(string value)
            {
                _value = value;
            }

            public static ScalingPolicyTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ScalingPolicyTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ScalingPolicyTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ScalingPolicyTypeEnum a, ScalingPolicyTypeEnum b)
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

            public static bool operator !=(ScalingPolicyTypeEnum a, ScalingPolicyTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 伸缩组ID。
        /// </summary>
        [SDKProperty("scaling_group_id", IsPath = true)]
        [JsonProperty("scaling_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// 伸缩策略名称。
        /// </summary>
        [SDKProperty("scaling_policy_name", IsQuery = true)]
        [JsonProperty("scaling_policy_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingPolicyName { get; set; }

        /// <summary>
        /// 策略类型。
        /// </summary>
        [SDKProperty("scaling_policy_type", IsQuery = true)]
        [JsonProperty("scaling_policy_type", NullValueHandling = NullValueHandling.Ignore)]
        public ScalingPolicyTypeEnum ScalingPolicyType { get; set; }
        /// <summary>
        /// 伸缩策略ID。
        /// </summary>
        [SDKProperty("scaling_policy_id", IsQuery = true)]
        [JsonProperty("scaling_policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingPolicyId { get; set; }

        /// <summary>
        /// 查询的起始行号，默认为0。
        /// </summary>
        [SDKProperty("start_number", IsQuery = true)]
        [JsonProperty("start_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? StartNumber { get; set; }

        /// <summary>
        /// 查询记录数，默认20，最大100。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListScalingPoliciesRequest {\n");
            sb.Append("  scalingGroupId: ").Append(ScalingGroupId).Append("\n");
            sb.Append("  scalingPolicyName: ").Append(ScalingPolicyName).Append("\n");
            sb.Append("  scalingPolicyType: ").Append(ScalingPolicyType).Append("\n");
            sb.Append("  scalingPolicyId: ").Append(ScalingPolicyId).Append("\n");
            sb.Append("  startNumber: ").Append(StartNumber).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListScalingPoliciesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListScalingPoliciesRequest input)
        {
            if (input == null) return false;
            if (this.ScalingGroupId != input.ScalingGroupId || (this.ScalingGroupId != null && !this.ScalingGroupId.Equals(input.ScalingGroupId))) return false;
            if (this.ScalingPolicyName != input.ScalingPolicyName || (this.ScalingPolicyName != null && !this.ScalingPolicyName.Equals(input.ScalingPolicyName))) return false;
            if (this.ScalingPolicyType != input.ScalingPolicyType) return false;
            if (this.ScalingPolicyId != input.ScalingPolicyId || (this.ScalingPolicyId != null && !this.ScalingPolicyId.Equals(input.ScalingPolicyId))) return false;
            if (this.StartNumber != input.StartNumber || (this.StartNumber != null && !this.StartNumber.Equals(input.StartNumber))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                if (this.ScalingGroupId != null) hashCode = hashCode * 59 + this.ScalingGroupId.GetHashCode();
                if (this.ScalingPolicyName != null) hashCode = hashCode * 59 + this.ScalingPolicyName.GetHashCode();
                hashCode = hashCode * 59 + this.ScalingPolicyType.GetHashCode();
                if (this.ScalingPolicyId != null) hashCode = hashCode * 59 + this.ScalingPolicyId.GetHashCode();
                if (this.StartNumber != null) hashCode = hashCode * 59 + this.StartNumber.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
