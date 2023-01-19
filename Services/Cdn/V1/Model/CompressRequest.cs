using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CompressRequest 
    {

        /// <summary>
        /// GZIP压缩开关。0关闭。1打开
        /// </summary>
        [JsonProperty("compress_switch", NullValueHandling = NullValueHandling.Ignore)]
        public int? CompressSwitch { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompressRequest {\n");
            sb.Append("  compressSwitch: ").Append(CompressSwitch).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CompressRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CompressRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CompressSwitch == input.CompressSwitch ||
                    (this.CompressSwitch != null &&
                    this.CompressSwitch.Equals(input.CompressSwitch))
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
                if (this.CompressSwitch != null)
                    hashCode = hashCode * 59 + this.CompressSwitch.GetHashCode();
                return hashCode;
            }
        }
    }
}
