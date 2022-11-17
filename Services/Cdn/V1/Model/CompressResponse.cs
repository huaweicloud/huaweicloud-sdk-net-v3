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
    public class CompressResponse 
    {

        /// <summary>
        /// GZIP压缩开关。0关闭。1打开
        /// </summary>
        [JsonProperty("compress_switch", NullValueHandling = NullValueHandling.Ignore)]
        public int? CompressSwitch { get; set; }

        /// <summary>
        /// GZIP压缩规则
        /// </summary>
        [JsonProperty("compress_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<CompressRules> CompressRules { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompressResponse {\n");
            sb.Append("  compressSwitch: ").Append(CompressSwitch).Append("\n");
            sb.Append("  compressRules: ").Append(CompressRules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CompressResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CompressResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CompressSwitch == input.CompressSwitch ||
                    (this.CompressSwitch != null &&
                    this.CompressSwitch.Equals(input.CompressSwitch))
                ) && 
                (
                    this.CompressRules == input.CompressRules ||
                    this.CompressRules != null &&
                    input.CompressRules != null &&
                    this.CompressRules.SequenceEqual(input.CompressRules)
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
                if (this.CompressRules != null)
                    hashCode = hashCode * 59 + this.CompressRules.GetHashCode();
                return hashCode;
            }
        }
    }
}
