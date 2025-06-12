using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 资源总量信息
    /// </summary>
    public class ResourcesCount 
    {

        /// <summary>
        /// 业务类型。
        /// </summary>
        [JsonProperty("business_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessType { get; set; }

        /// <summary>
        /// 资源总数。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Count { get; set; }

        /// <summary>
        /// 计费类型。 * PERIODIC: 包周期 * ONE_TIME：一次性 * ON_DEMAND：按需
        /// </summary>
        [JsonProperty("charging_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargingMode { get; set; }

        /// <summary>
        /// 资源来源。 * PURCHASED: 购买 * SP_ALLOCATED：SP分配 * ADMIN_ALLOCATED：系统管理员分配
        /// </summary>
        [JsonProperty("resource_source", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceSource { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourcesCount {\n");
            sb.Append("  businessType: ").Append(BusinessType).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  chargingMode: ").Append(ChargingMode).Append("\n");
            sb.Append("  resourceSource: ").Append(ResourceSource).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourcesCount);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourcesCount input)
        {
            if (input == null) return false;
            if (this.BusinessType != input.BusinessType || (this.BusinessType != null && !this.BusinessType.Equals(input.BusinessType))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.ChargingMode != input.ChargingMode || (this.ChargingMode != null && !this.ChargingMode.Equals(input.ChargingMode))) return false;
            if (this.ResourceSource != input.ResourceSource || (this.ResourceSource != null && !this.ResourceSource.Equals(input.ResourceSource))) return false;

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
                if (this.BusinessType != null) hashCode = hashCode * 59 + this.BusinessType.GetHashCode();
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.ChargingMode != null) hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                if (this.ResourceSource != null) hashCode = hashCode * 59 + this.ResourceSource.GetHashCode();
                return hashCode;
            }
        }
    }
}
