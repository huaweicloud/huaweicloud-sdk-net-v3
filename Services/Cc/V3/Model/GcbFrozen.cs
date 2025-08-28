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
    /// 
    /// </summary>
    public class GcbFrozen 
    {

        /// <summary>
        /// 功能说明: 全域互联带宽是否冻结。 取值范围：     true-冻结     false-非冻结
        /// </summary>
        [JsonProperty("frozen", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Frozen { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GcbFrozen {\n");
            sb.Append("  frozen: ").Append(Frozen).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GcbFrozen);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GcbFrozen input)
        {
            if (input == null) return false;
            if (this.Frozen != input.Frozen || (this.Frozen != null && !this.Frozen.Equals(input.Frozen))) return false;

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
                if (this.Frozen != null) hashCode = hashCode * 59 + this.Frozen.GetHashCode();
                return hashCode;
            }
        }
    }
}
