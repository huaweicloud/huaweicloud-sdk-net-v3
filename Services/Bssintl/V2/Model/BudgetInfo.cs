using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bssintl.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BudgetInfo 
    {
        /// <summary>
        /// |参数名称：预算模式| |参数的约束及描述：MONTHLY 月度预算 PACKAGE 一次性预算|
        /// </summary>
        /// <value>|参数名称：预算模式| |参数的约束及描述：MONTHLY 月度预算 PACKAGE 一次性预算|</value>
        [JsonConverter(typeof(EnumClassConverter<BudgetTypeEnum>))]
        public class BudgetTypeEnum
        {
            /// <summary>
            /// Enum MONTHLY for value: MONTHLY
            /// </summary>
            public static readonly BudgetTypeEnum MONTHLY = new BudgetTypeEnum("MONTHLY");

            /// <summary>
            /// Enum PACKAGE for value: PACKAGE
            /// </summary>
            public static readonly BudgetTypeEnum PACKAGE = new BudgetTypeEnum("PACKAGE");

            private static readonly Dictionary<string, BudgetTypeEnum> StaticFields =
            new Dictionary<string, BudgetTypeEnum>()
            {
                { "MONTHLY", MONTHLY },
                { "PACKAGE", PACKAGE },
            };

            private string _value;

            public BudgetTypeEnum()
            {

            }

            public BudgetTypeEnum(string value)
            {
                _value = value;
            }

            public static BudgetTypeEnum FromValue(string value)
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

                if (this.Equals(obj as BudgetTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(BudgetTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(BudgetTypeEnum a, BudgetTypeEnum b)
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

            public static bool operator !=(BudgetTypeEnum a, BudgetTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// |参数名称：客户账号ID||参数的约束及描述：必填参数，范围限制:1-64|
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; set; }

        /// <summary>
        /// |参数名称：初始预算金额。| |参数的约束及描述：非必填，初始预算金额。|
        /// </summary>
        [JsonProperty("budget_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? BudgetAmount { get; set; }

        /// <summary>
        /// |参数名称：已经使用的预算。| |参数的约束及描述：已经使用的预算。非必填，该预算存在一定的时延和误差。|
        /// </summary>
        [JsonProperty("used_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? UsedAmount { get; set; }

        /// <summary>
        /// |参数名称：预算模式| |参数的约束及描述：MONTHLY 月度预算 PACKAGE 一次性预算|
        /// </summary>
        [JsonProperty("budget_type", NullValueHandling = NullValueHandling.Ignore)]
        public BudgetTypeEnum BudgetType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BudgetInfo {\n");
            sb.Append("  customerId: ").Append(CustomerId).Append("\n");
            sb.Append("  budgetAmount: ").Append(BudgetAmount).Append("\n");
            sb.Append("  usedAmount: ").Append(UsedAmount).Append("\n");
            sb.Append("  budgetType: ").Append(BudgetType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BudgetInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BudgetInfo input)
        {
            if (input == null) return false;
            if (this.CustomerId != input.CustomerId || (this.CustomerId != null && !this.CustomerId.Equals(input.CustomerId))) return false;
            if (this.BudgetAmount != input.BudgetAmount || (this.BudgetAmount != null && !this.BudgetAmount.Equals(input.BudgetAmount))) return false;
            if (this.UsedAmount != input.UsedAmount || (this.UsedAmount != null && !this.UsedAmount.Equals(input.UsedAmount))) return false;
            if (this.BudgetType != input.BudgetType) return false;

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
                if (this.CustomerId != null) hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.BudgetAmount != null) hashCode = hashCode * 59 + this.BudgetAmount.GetHashCode();
                if (this.UsedAmount != null) hashCode = hashCode * 59 + this.UsedAmount.GetHashCode();
                hashCode = hashCode * 59 + this.BudgetType.GetHashCode();
                return hashCode;
            }
        }
    }
}
