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
    /// 批量绑定全域公网带宽请求体对象
    /// </summary>
    public class BatchAttachInternetBandwidthsGlobalEipRequestBody 
    {

        /// <summary>
        /// 批量绑定全域公网带宽请求体对象
        /// </summary>
        [JsonProperty("global_eips", NullValueHandling = NullValueHandling.Ignore)]
        public List<Object> GlobalEips { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchAttachInternetBandwidthsGlobalEipRequestBody {\n");
            sb.Append("  globalEips: ").Append(GlobalEips).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchAttachInternetBandwidthsGlobalEipRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchAttachInternetBandwidthsGlobalEipRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GlobalEips == input.GlobalEips ||
                    this.GlobalEips != null &&
                    input.GlobalEips != null &&
                    this.GlobalEips.SequenceEqual(input.GlobalEips)
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
                if (this.GlobalEips != null)
                    hashCode = hashCode * 59 + this.GlobalEips.GetHashCode();
                return hashCode;
            }
        }
    }
}
