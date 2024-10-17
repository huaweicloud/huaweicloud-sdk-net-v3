using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CdnIps 
    {

        /// <summary>
        /// 需查询的IP地址。
        /// </summary>
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// 是否是华为云CDN节点。（true:是华为云CDN节点，false:不是华为云CDN节点）
        /// </summary>
        [JsonProperty("belongs", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Belongs { get; set; }

        /// <summary>
        /// IP归属地省份。（Unknown:表示未知归属地）
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 运营商名称。如果IP归属地未知，该字段返回null。
        /// </summary>
        [JsonProperty("isp", NullValueHandling = NullValueHandling.Ignore)]
        public string Isp { get; set; }

        /// <summary>
        /// 平台。如果IP归属地未知，该字段返回null。
        /// </summary>
        [JsonProperty("platform", NullValueHandling = NullValueHandling.Ignore)]
        public string Platform { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CdnIps {\n");
            sb.Append("  ip: ").Append(Ip).Append("\n");
            sb.Append("  belongs: ").Append(Belongs).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  isp: ").Append(Isp).Append("\n");
            sb.Append("  platform: ").Append(Platform).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CdnIps);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CdnIps input)
        {
            if (input == null) return false;
            if (this.Ip != input.Ip || (this.Ip != null && !this.Ip.Equals(input.Ip))) return false;
            if (this.Belongs != input.Belongs || (this.Belongs != null && !this.Belongs.Equals(input.Belongs))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.Isp != input.Isp || (this.Isp != null && !this.Isp.Equals(input.Isp))) return false;
            if (this.Platform != input.Platform || (this.Platform != null && !this.Platform.Equals(input.Platform))) return false;

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
                if (this.Ip != null) hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.Belongs != null) hashCode = hashCode * 59 + this.Belongs.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.Isp != null) hashCode = hashCode * 59 + this.Isp.GetHashCode();
                if (this.Platform != null) hashCode = hashCode * 59 + this.Platform.GetHashCode();
                return hashCode;
            }
        }
    }
}
