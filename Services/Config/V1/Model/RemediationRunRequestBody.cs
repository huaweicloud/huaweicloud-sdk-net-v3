using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// 手动执行修正的范围。
    /// </summary>
    public class RemediationRunRequestBody 
    {

        /// <summary>
        /// 是否选择对所有不合规资源执行补救。
        /// </summary>
        [JsonProperty("all_supported", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllSupported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resource_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ResourceIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemediationRunRequestBody {\n");
            sb.Append("  allSupported: ").Append(AllSupported).Append("\n");
            sb.Append("  resourceIds: ").Append(ResourceIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RemediationRunRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RemediationRunRequestBody input)
        {
            if (input == null) return false;
            if (this.AllSupported != input.AllSupported || (this.AllSupported != null && !this.AllSupported.Equals(input.AllSupported))) return false;
            if (this.ResourceIds != input.ResourceIds || (this.ResourceIds != null && input.ResourceIds != null && !this.ResourceIds.SequenceEqual(input.ResourceIds))) return false;

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
                if (this.AllSupported != null) hashCode = hashCode * 59 + this.AllSupported.GetHashCode();
                if (this.ResourceIds != null) hashCode = hashCode * 59 + this.ResourceIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
