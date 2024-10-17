using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 磁盘扩容请求体。
    /// </summary>
    public class ChEnlargeVolumeRequestBody 
    {

        /// <summary>
        /// 磁盘容量。取值范围：50GB~32000GB。
        /// </summary>
        [JsonProperty("size_in_gb", NullValueHandling = NullValueHandling.Ignore)]
        public int? SizeInGb { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChEnlargeVolumeRequestBody {\n");
            sb.Append("  sizeInGb: ").Append(SizeInGb).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChEnlargeVolumeRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChEnlargeVolumeRequestBody input)
        {
            if (input == null) return false;
            if (this.SizeInGb != input.SizeInGb || (this.SizeInGb != null && !this.SizeInGb.Equals(input.SizeInGb))) return false;

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
                if (this.SizeInGb != null) hashCode = hashCode * 59 + this.SizeInGb.GetHashCode();
                return hashCode;
            }
        }
    }
}
