using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bss.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class IncentiveAndDiscountPolicy 
    {

        /// <summary>
        /// 云服务类型列表。
        /// </summary>
        [JsonProperty("service_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceTypeCode { get; set; }

        /// <summary>
        /// 云服务类型名称。例如ECS的云服务类型名称为“弹性云服务器”。
        /// </summary>
        [JsonProperty("service_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceTypeName { get; set; }

        /// <summary>
        /// 激励策略。 0：非特定产品1：特定产品2：无业绩无返点13：有业绩无返点
        /// </summary>
        [JsonProperty("incentive_policy", NullValueHandling = NullValueHandling.Ignore)]
        public string IncentivePolicy { get; set; }

        /// <summary>
        /// 是否允许应用伙伴授予折扣。 YES：允许应用NO：不许应用
        /// </summary>
        [JsonProperty("allow_discount", NullValueHandling = NullValueHandling.Ignore)]
        public string AllowDiscount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IncentiveAndDiscountPolicy {\n");
            sb.Append("  serviceTypeCode: ").Append(ServiceTypeCode).Append("\n");
            sb.Append("  serviceTypeName: ").Append(ServiceTypeName).Append("\n");
            sb.Append("  incentivePolicy: ").Append(IncentivePolicy).Append("\n");
            sb.Append("  allowDiscount: ").Append(AllowDiscount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IncentiveAndDiscountPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IncentiveAndDiscountPolicy input)
        {
            if (input == null) return false;
            if (this.ServiceTypeCode != input.ServiceTypeCode || (this.ServiceTypeCode != null && !this.ServiceTypeCode.Equals(input.ServiceTypeCode))) return false;
            if (this.ServiceTypeName != input.ServiceTypeName || (this.ServiceTypeName != null && !this.ServiceTypeName.Equals(input.ServiceTypeName))) return false;
            if (this.IncentivePolicy != input.IncentivePolicy || (this.IncentivePolicy != null && !this.IncentivePolicy.Equals(input.IncentivePolicy))) return false;
            if (this.AllowDiscount != input.AllowDiscount || (this.AllowDiscount != null && !this.AllowDiscount.Equals(input.AllowDiscount))) return false;

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
                if (this.ServiceTypeCode != null) hashCode = hashCode * 59 + this.ServiceTypeCode.GetHashCode();
                if (this.ServiceTypeName != null) hashCode = hashCode * 59 + this.ServiceTypeName.GetHashCode();
                if (this.IncentivePolicy != null) hashCode = hashCode * 59 + this.IncentivePolicy.GetHashCode();
                if (this.AllowDiscount != null) hashCode = hashCode * 59 + this.AllowDiscount.GetHashCode();
                return hashCode;
            }
        }
    }
}
