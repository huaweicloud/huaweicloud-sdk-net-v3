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
    public class NewCustomerTagItem 
    {

        /// <summary>
        /// 客户ID。
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; set; }

        /// <summary>
        /// 新客标签类型。 SMB：SMB新客标签。
        /// </summary>
        [JsonProperty("customer_tag_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerTagType { get; set; }

        /// <summary>
        /// 新客标签。 Y：合格新客N：非新客UNDETERMINED：未达标新客，即有新客资格但尚未成为新客
        /// </summary>
        [JsonProperty("new_customer_tag", NullValueHandling = NullValueHandling.Ignore)]
        public string NewCustomerTag { get; set; }

        /// <summary>
        /// 生效月份。 格式为YYYY-MM。
        /// </summary>
        [JsonProperty("effective_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// 失效月份。 格式为YYYY-MM。
        /// </summary>
        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpireTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewCustomerTagItem {\n");
            sb.Append("  customerId: ").Append(CustomerId).Append("\n");
            sb.Append("  customerTagType: ").Append(CustomerTagType).Append("\n");
            sb.Append("  newCustomerTag: ").Append(NewCustomerTag).Append("\n");
            sb.Append("  effectiveTime: ").Append(EffectiveTime).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NewCustomerTagItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NewCustomerTagItem input)
        {
            if (input == null) return false;
            if (this.CustomerId != input.CustomerId || (this.CustomerId != null && !this.CustomerId.Equals(input.CustomerId))) return false;
            if (this.CustomerTagType != input.CustomerTagType || (this.CustomerTagType != null && !this.CustomerTagType.Equals(input.CustomerTagType))) return false;
            if (this.NewCustomerTag != input.NewCustomerTag || (this.NewCustomerTag != null && !this.NewCustomerTag.Equals(input.NewCustomerTag))) return false;
            if (this.EffectiveTime != input.EffectiveTime || (this.EffectiveTime != null && !this.EffectiveTime.Equals(input.EffectiveTime))) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;

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
                if (this.CustomerTagType != null) hashCode = hashCode * 59 + this.CustomerTagType.GetHashCode();
                if (this.NewCustomerTag != null) hashCode = hashCode * 59 + this.NewCustomerTag.GetHashCode();
                if (this.EffectiveTime != null) hashCode = hashCode * 59 + this.EffectiveTime.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
