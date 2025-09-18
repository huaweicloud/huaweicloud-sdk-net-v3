using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 桌面小时包资源。
    /// </summary>
    public class HourPackageResource 
    {
        /// <summary>
        /// 时长用尽策略：   - SHUTDOWN_OR_HIBERNATE：自动关机/休眠。 - PAY_PER_USE：自动按需计费。
        /// </summary>
        /// <value>时长用尽策略：   - SHUTDOWN_OR_HIBERNATE：自动关机/休眠。 - PAY_PER_USE：自动按需计费。</value>
        [JsonConverter(typeof(EnumClassConverter<UsedUpPolicyEnum>))]
        public class UsedUpPolicyEnum
        {
            /// <summary>
            /// Enum SHUTDOWN_OR_HIBERNATE for value: SHUTDOWN_OR_HIBERNATE
            /// </summary>
            public static readonly UsedUpPolicyEnum SHUTDOWN_OR_HIBERNATE = new UsedUpPolicyEnum("SHUTDOWN_OR_HIBERNATE");

            /// <summary>
            /// Enum PAY_PER_USE for value: PAY_PER_USE
            /// </summary>
            public static readonly UsedUpPolicyEnum PAY_PER_USE = new UsedUpPolicyEnum("PAY_PER_USE");

            private static readonly Dictionary<string, UsedUpPolicyEnum> StaticFields =
            new Dictionary<string, UsedUpPolicyEnum>()
            {
                { "SHUTDOWN_OR_HIBERNATE", SHUTDOWN_OR_HIBERNATE },
                { "PAY_PER_USE", PAY_PER_USE },
            };

            private string _value;

            public UsedUpPolicyEnum()
            {

            }

            public UsedUpPolicyEnum(string value)
            {
                _value = value;
            }

            public static UsedUpPolicyEnum FromValue(string value)
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

                if (this.Equals(obj as UsedUpPolicyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(UsedUpPolicyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(UsedUpPolicyEnum a, UsedUpPolicyEnum b)
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

            public static bool operator !=(UsedUpPolicyEnum a, UsedUpPolicyEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 订购周期类型：2：月；3：年;必填。
        /// </summary>
        [JsonProperty("period_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodType { get; set; }

        /// <summary>
        /// 订购周期数。
        /// </summary>
        [JsonProperty("period_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodNum { get; set; }

        /// <summary>
        /// 是否自动续订。
        /// </summary>
        [JsonProperty("is_auto_renew", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsAutoRenew { get; set; }

        /// <summary>
        /// 时长用尽策略：   - SHUTDOWN_OR_HIBERNATE：自动关机/休眠。 - PAY_PER_USE：自动按需计费。
        /// </summary>
        [JsonProperty("used_up_policy", NullValueHandling = NullValueHandling.Ignore)]
        public UsedUpPolicyEnum UsedUpPolicy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("create_desktops", NullValueHandling = NullValueHandling.Ignore)]
        public CreateDesktopReq CreateDesktops { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HourPackageResource {\n");
            sb.Append("  periodType: ").Append(PeriodType).Append("\n");
            sb.Append("  periodNum: ").Append(PeriodNum).Append("\n");
            sb.Append("  isAutoRenew: ").Append(IsAutoRenew).Append("\n");
            sb.Append("  usedUpPolicy: ").Append(UsedUpPolicy).Append("\n");
            sb.Append("  createDesktops: ").Append(CreateDesktops).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HourPackageResource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HourPackageResource input)
        {
            if (input == null) return false;
            if (this.PeriodType != input.PeriodType || (this.PeriodType != null && !this.PeriodType.Equals(input.PeriodType))) return false;
            if (this.PeriodNum != input.PeriodNum || (this.PeriodNum != null && !this.PeriodNum.Equals(input.PeriodNum))) return false;
            if (this.IsAutoRenew != input.IsAutoRenew || (this.IsAutoRenew != null && !this.IsAutoRenew.Equals(input.IsAutoRenew))) return false;
            if (this.UsedUpPolicy != input.UsedUpPolicy) return false;
            if (this.CreateDesktops != input.CreateDesktops || (this.CreateDesktops != null && !this.CreateDesktops.Equals(input.CreateDesktops))) return false;

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
                if (this.PeriodType != null) hashCode = hashCode * 59 + this.PeriodType.GetHashCode();
                if (this.PeriodNum != null) hashCode = hashCode * 59 + this.PeriodNum.GetHashCode();
                if (this.IsAutoRenew != null) hashCode = hashCode * 59 + this.IsAutoRenew.GetHashCode();
                hashCode = hashCode * 59 + this.UsedUpPolicy.GetHashCode();
                if (this.CreateDesktops != null) hashCode = hashCode * 59 + this.CreateDesktops.GetHashCode();
                return hashCode;
            }
        }
    }
}
