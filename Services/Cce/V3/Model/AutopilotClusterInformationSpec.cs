using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AutopilotClusterInformationSpec 
    {

        /// <summary>
        /// 集群的描述信息。  1. 字符取值范围[0,200]。不包含~$%^&amp;*&lt;&gt;[]{}()&#39;\&quot;#\\等特殊字符。 2. 仅运行（Available）的集群允许修改。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 集群的API Server服务端证书中的自定义SAN（Subject Alternative Name）字段，遵从SSL标准X509定义的格式规范。  1. 不允许出现同名重复。 2. 格式符合IP和域名格式。  示例: &#x60;&#x60;&#x60; SAN 1: DNS Name&#x3D;example.com SAN 2: DNS Name&#x3D;www.example.com SAN 3: DNS Name&#x3D;example.net SAN 4: IP Address&#x3D;93.184.216.34 &#x60;&#x60;&#x60;
        /// </summary>
        [JsonProperty("customSan", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CustomSan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("eniNetwork", NullValueHandling = NullValueHandling.Ignore)]
        public AutopilotEniNetworkUpdate EniNetwork { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutopilotClusterInformationSpec {\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  customSan: ").Append(CustomSan).Append("\n");
            sb.Append("  eniNetwork: ").Append(EniNetwork).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AutopilotClusterInformationSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AutopilotClusterInformationSpec input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.CustomSan == input.CustomSan ||
                    this.CustomSan != null &&
                    input.CustomSan != null &&
                    this.CustomSan.SequenceEqual(input.CustomSan)
                ) && 
                (
                    this.EniNetwork == input.EniNetwork ||
                    (this.EniNetwork != null &&
                    this.EniNetwork.Equals(input.EniNetwork))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CustomSan != null)
                    hashCode = hashCode * 59 + this.CustomSan.GetHashCode();
                if (this.EniNetwork != null)
                    hashCode = hashCode * 59 + this.EniNetwork.GetHashCode();
                return hashCode;
            }
        }
    }
}
