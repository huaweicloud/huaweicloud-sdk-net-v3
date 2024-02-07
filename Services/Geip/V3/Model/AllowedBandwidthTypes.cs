using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Geip.V3.Model
{
    /// <summary>
    /// 地址池支持的全域公网带宽类型资源
    /// </summary>
    public class AllowedBandwidthTypes 
    {

        /// <summary>
        /// 全域公网带宽类型名称
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 中文名称
        /// </summary>
        [JsonProperty("cn_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CnName { get; set; }

        /// <summary>
        /// 英文名称
        /// </summary>
        [JsonProperty("en_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EnName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AllowedBandwidthTypes {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  cnName: ").Append(CnName).Append("\n");
            sb.Append("  enName: ").Append(EnName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AllowedBandwidthTypes);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AllowedBandwidthTypes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.CnName == input.CnName ||
                    (this.CnName != null &&
                    this.CnName.Equals(input.CnName))
                ) && 
                (
                    this.EnName == input.EnName ||
                    (this.EnName != null &&
                    this.EnName.Equals(input.EnName))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.CnName != null)
                    hashCode = hashCode * 59 + this.CnName.GetHashCode();
                if (this.EnName != null)
                    hashCode = hashCode * 59 + this.EnName.GetHashCode();
                return hashCode;
            }
        }
    }
}
