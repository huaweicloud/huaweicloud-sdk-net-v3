using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 服务商信息。
    /// </summary>
    public class BusinessPartner 
    {

        /// <summary>
        /// 服务商ID。
        /// </summary>
        [JsonProperty("bp_domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BpDomainId { get; set; }

        /// <summary>
        /// 服务商名称。
        /// </summary>
        [JsonProperty("bp_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BpName { get; set; }

        /// <summary>
        /// 优先级，整数取值范围1-100，数值越小优先级越高。
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public int? Order { get; set; }

        /// <summary>
        /// 是否是国际站服务商。
        /// </summary>
        [JsonProperty("international", NullValueHandling = NullValueHandling.Ignore)]
        public bool? International { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessPartner {\n");
            sb.Append("  bpDomainId: ").Append(BpDomainId).Append("\n");
            sb.Append("  bpName: ").Append(BpName).Append("\n");
            sb.Append("  order: ").Append(Order).Append("\n");
            sb.Append("  international: ").Append(International).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BusinessPartner);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BusinessPartner input)
        {
            if (input == null) return false;
            if (this.BpDomainId != input.BpDomainId || (this.BpDomainId != null && !this.BpDomainId.Equals(input.BpDomainId))) return false;
            if (this.BpName != input.BpName || (this.BpName != null && !this.BpName.Equals(input.BpName))) return false;
            if (this.Order != input.Order || (this.Order != null && !this.Order.Equals(input.Order))) return false;
            if (this.International != input.International || (this.International != null && !this.International.Equals(input.International))) return false;

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
                if (this.BpDomainId != null) hashCode = hashCode * 59 + this.BpDomainId.GetHashCode();
                if (this.BpName != null) hashCode = hashCode * 59 + this.BpName.GetHashCode();
                if (this.Order != null) hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.International != null) hashCode = hashCode * 59 + this.International.GetHashCode();
                return hashCode;
            }
        }
    }
}
