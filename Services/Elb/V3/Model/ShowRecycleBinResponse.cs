using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowRecycleBinResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("recycle_bin", NullValueHandling = NullValueHandling.Ignore)]
        public RecycleBinResponseBody RecycleBin { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRecycleBinResponse {\n");
            sb.Append("  recycleBin: ").Append(RecycleBin).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRecycleBinResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRecycleBinResponse input)
        {
            if (input == null) return false;
            if (this.RecycleBin != input.RecycleBin || (this.RecycleBin != null && !this.RecycleBin.Equals(input.RecycleBin))) return false;

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
                if (this.RecycleBin != null) hashCode = hashCode * 59 + this.RecycleBin.GetHashCode();
                return hashCode;
            }
        }
    }
}
