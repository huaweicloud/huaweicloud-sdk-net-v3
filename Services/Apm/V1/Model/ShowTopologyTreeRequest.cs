using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowTopologyTreeRequest 
    {

        /// <summary>
        /// 区域id。
        /// </summary>
        [SDKProperty("region_id", IsQuery = true)]
        [JsonProperty("region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionId { get; set; }

        /// <summary>
        /// 应用id。
        /// </summary>
        [SDKProperty("business_id", IsQuery = true)]
        [JsonProperty("business_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? BusinessId { get; set; }

        /// <summary>
        /// 环境标签id。
        /// </summary>
        [SDKProperty("env_tag_id", IsQuery = true)]
        [JsonProperty("env_tag_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? EnvTagId { get; set; }

        /// <summary>
        /// 环境关键字。
        /// </summary>
        [SDKProperty("env_keyword", IsQuery = true)]
        [JsonProperty("env_keyword", NullValueHandling = NullValueHandling.Ignore)]
        public string EnvKeyword { get; set; }

        /// <summary>
        /// 应用id。
        /// </summary>
        [SDKProperty("x-business-id", IsHeader = true)]
        [JsonProperty("x-business-id", NullValueHandling = NullValueHandling.Ignore)]
        public long? XBusinessId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTopologyTreeRequest {\n");
            sb.Append("  regionId: ").Append(RegionId).Append("\n");
            sb.Append("  businessId: ").Append(BusinessId).Append("\n");
            sb.Append("  envTagId: ").Append(EnvTagId).Append("\n");
            sb.Append("  envKeyword: ").Append(EnvKeyword).Append("\n");
            sb.Append("  xBusinessId: ").Append(XBusinessId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTopologyTreeRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTopologyTreeRequest input)
        {
            if (input == null) return false;
            if (this.RegionId != input.RegionId || (this.RegionId != null && !this.RegionId.Equals(input.RegionId))) return false;
            if (this.BusinessId != input.BusinessId || (this.BusinessId != null && !this.BusinessId.Equals(input.BusinessId))) return false;
            if (this.EnvTagId != input.EnvTagId || (this.EnvTagId != null && !this.EnvTagId.Equals(input.EnvTagId))) return false;
            if (this.EnvKeyword != input.EnvKeyword || (this.EnvKeyword != null && !this.EnvKeyword.Equals(input.EnvKeyword))) return false;
            if (this.XBusinessId != input.XBusinessId || (this.XBusinessId != null && !this.XBusinessId.Equals(input.XBusinessId))) return false;

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
                if (this.RegionId != null) hashCode = hashCode * 59 + this.RegionId.GetHashCode();
                if (this.BusinessId != null) hashCode = hashCode * 59 + this.BusinessId.GetHashCode();
                if (this.EnvTagId != null) hashCode = hashCode * 59 + this.EnvTagId.GetHashCode();
                if (this.EnvKeyword != null) hashCode = hashCode * 59 + this.EnvKeyword.GetHashCode();
                if (this.XBusinessId != null) hashCode = hashCode * 59 + this.XBusinessId.GetHashCode();
                return hashCode;
            }
        }
    }
}
