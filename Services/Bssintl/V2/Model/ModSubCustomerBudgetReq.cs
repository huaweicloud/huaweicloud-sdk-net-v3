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
    public class ModSubCustomerBudgetReq 
    {
        /// <summary>
        /// |参数名称：预算模式| |参数的约束及描述：MONTHLY 月度预算 PACKAGE 一次性预算 ，此参数不携带或携带值为null时，默认值为MONTHLY。|
        /// </summary>
        /// <value>|参数名称：预算模式| |参数的约束及描述：MONTHLY 月度预算 PACKAGE 一次性预算 ，此参数不携带或携带值为null时，默认值为MONTHLY。|</value>
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

            public static bool operator !=(BudgetTypeEnum a, BudgetTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 客户账号ID。您可以调用查询客户列表接口获取customer_id。
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; set; }

        /// <summary>
        /// 调整的目标金额。 单位：元。精确至小数点后2位。
        /// </summary>
        [JsonProperty("budget_amount", NullValueHandling = NullValueHandling.Ignore)]
        public double? BudgetAmount { get; set; }

        /// <summary>
        /// 是否在设置客户预算的同时解除账号冻结： 0：否1：是 默认值为0。
        /// </summary>
        [JsonProperty("cancel_partner_frozen", NullValueHandling = NullValueHandling.Ignore)]
        public string CancelPartnerFrozen { get; set; }

        /// <summary>
        /// 云经销商ID。获取方法请参见查询云经销商列表。如果需要查询云经销商的子客户列表，必须携带该字段。除此之外，此参数不做处理。
        /// </summary>
        [JsonProperty("indirect_partner_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IndirectPartnerId { get; set; }

        /// <summary>
        /// |参数名称：预算模式| |参数的约束及描述：MONTHLY 月度预算 PACKAGE 一次性预算 ，此参数不携带或携带值为null时，默认值为MONTHLY。|
        /// </summary>
        [JsonProperty("budget_type", NullValueHandling = NullValueHandling.Ignore)]
        public BudgetTypeEnum BudgetType { get; set; }
        /// <summary>
        /// |参数名称：设置超预算时是否自动冻结| |参数的约束及描述：0：手工冻结 1：自动冻结，此参数不携带或携带值为null或携带值为空时，字段不生效。|
        /// </summary>
        [JsonProperty("frozen_operate_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? FrozenOperateType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModSubCustomerBudgetReq {\n");
            sb.Append("  customerId: ").Append(CustomerId).Append("\n");
            sb.Append("  budgetAmount: ").Append(BudgetAmount).Append("\n");
            sb.Append("  cancelPartnerFrozen: ").Append(CancelPartnerFrozen).Append("\n");
            sb.Append("  indirectPartnerId: ").Append(IndirectPartnerId).Append("\n");
            sb.Append("  budgetType: ").Append(BudgetType).Append("\n");
            sb.Append("  frozenOperateType: ").Append(FrozenOperateType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModSubCustomerBudgetReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModSubCustomerBudgetReq input)
        {
            if (input == null) return false;
            if (this.CustomerId != input.CustomerId || (this.CustomerId != null && !this.CustomerId.Equals(input.CustomerId))) return false;
            if (this.BudgetAmount != input.BudgetAmount || (this.BudgetAmount != null && !this.BudgetAmount.Equals(input.BudgetAmount))) return false;
            if (this.CancelPartnerFrozen != input.CancelPartnerFrozen || (this.CancelPartnerFrozen != null && !this.CancelPartnerFrozen.Equals(input.CancelPartnerFrozen))) return false;
            if (this.IndirectPartnerId != input.IndirectPartnerId || (this.IndirectPartnerId != null && !this.IndirectPartnerId.Equals(input.IndirectPartnerId))) return false;
            if (this.BudgetType != input.BudgetType) return false;
            if (this.FrozenOperateType != input.FrozenOperateType || (this.FrozenOperateType != null && !this.FrozenOperateType.Equals(input.FrozenOperateType))) return false;

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
                if (this.CancelPartnerFrozen != null) hashCode = hashCode * 59 + this.CancelPartnerFrozen.GetHashCode();
                if (this.IndirectPartnerId != null) hashCode = hashCode * 59 + this.IndirectPartnerId.GetHashCode();
                hashCode = hashCode * 59 + this.BudgetType.GetHashCode();
                if (this.FrozenOperateType != null) hashCode = hashCode * 59 + this.FrozenOperateType.GetHashCode();
                return hashCode;
            }
        }
    }
}
