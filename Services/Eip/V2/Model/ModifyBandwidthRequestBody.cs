using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V2.Model
{
    /// <summary>
    /// 批量更新带宽对象的请求体
    /// </summary>
    public class ModifyBandwidthRequestBody 
    {

        /// <summary>
        /// 更新带宽列表
        /// </summary>
        [JsonProperty("bandwidths", NullValueHandling = NullValueHandling.Ignore)]
        public List<ModifyBandwidthOption> Bandwidths { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyBandwidthRequestBody {\n");
            sb.Append("  bandwidths: ").Append(Bandwidths).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyBandwidthRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyBandwidthRequestBody input)
        {
            if (input == null) return false;
            if (this.Bandwidths != input.Bandwidths || (this.Bandwidths != null && input.Bandwidths != null && !this.Bandwidths.SequenceEqual(input.Bandwidths))) return false;

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
                if (this.Bandwidths != null) hashCode = hashCode * 59 + this.Bandwidths.GetHashCode();
                return hashCode;
            }
        }
    }
}
