using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class WafGeoIpRule 
    {

        /// <summary>
        /// 地理位置
        /// </summary>
        [JsonProperty("geoip", NullValueHandling = NullValueHandling.Ignore)]
        public string Geoip { get; set; }

        /// <summary>
        /// id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 防护区域，0-大陆，1-海外
        /// </summary>
        [JsonProperty("overseas_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? OverseasType { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public int? Timestamp { get; set; }

        /// <summary>
        /// 防护动作 0-阻断，1-放行，2-仅记录
        /// </summary>
        [JsonProperty("white", NullValueHandling = NullValueHandling.Ignore)]
        public int? White { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WafGeoIpRule {\n");
            sb.Append("  geoip: ").Append(Geoip).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  overseasType: ").Append(OverseasType).Append("\n");
            sb.Append("  timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  white: ").Append(White).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WafGeoIpRule);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WafGeoIpRule input)
        {
            if (input == null) return false;
            if (this.Geoip != input.Geoip || (this.Geoip != null && !this.Geoip.Equals(input.Geoip))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.OverseasType != input.OverseasType || (this.OverseasType != null && !this.OverseasType.Equals(input.OverseasType))) return false;
            if (this.Timestamp != input.Timestamp || (this.Timestamp != null && !this.Timestamp.Equals(input.Timestamp))) return false;
            if (this.White != input.White || (this.White != null && !this.White.Equals(input.White))) return false;

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
                if (this.Geoip != null) hashCode = hashCode * 59 + this.Geoip.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OverseasType != null) hashCode = hashCode * 59 + this.OverseasType.GetHashCode();
                if (this.Timestamp != null) hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.White != null) hashCode = hashCode * 59 + this.White.GetHashCode();
                return hashCode;
            }
        }
    }
}
