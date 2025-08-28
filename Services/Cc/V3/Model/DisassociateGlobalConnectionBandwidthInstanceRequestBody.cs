using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 全域互联带宽解绑实例详细信息。
    /// </summary>
    public class DisassociateGlobalConnectionBandwidthInstanceRequestBody 
    {

        /// <summary>
        /// 全域互联带宽解绑实例详细信息。
        /// </summary>
        [JsonProperty("gcbandwidths", NullValueHandling = NullValueHandling.Ignore)]
        public List<DisassociateGlobalConnectionBandwidthInstanceRequestInfo> Gcbandwidths { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DisassociateGlobalConnectionBandwidthInstanceRequestBody {\n");
            sb.Append("  gcbandwidths: ").Append(Gcbandwidths).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DisassociateGlobalConnectionBandwidthInstanceRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DisassociateGlobalConnectionBandwidthInstanceRequestBody input)
        {
            if (input == null) return false;
            if (this.Gcbandwidths != input.Gcbandwidths || (this.Gcbandwidths != null && input.Gcbandwidths != null && !this.Gcbandwidths.SequenceEqual(input.Gcbandwidths))) return false;

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
                if (this.Gcbandwidths != null) hashCode = hashCode * 59 + this.Gcbandwidths.GetHashCode();
                return hashCode;
            }
        }
    }
}
