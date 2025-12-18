using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateLongAKSKConfigRequestBody 
    {

        /// <summary>
        /// **参数解释：** 新建集群是否启用LongAKSK。 **约束限制：** 不涉及 **取值范围：** - false: 新建集群不启用LongAKSK - true: 新建集群启用LongAKSK  **默认取值：** 不涉及 
        /// </summary>
        [JsonProperty("enableLongAKSKInNewCluster", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableLongAKSKInNewCluster { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateLongAKSKConfigRequestBody {\n");
            sb.Append("  enableLongAKSKInNewCluster: ").Append(EnableLongAKSKInNewCluster).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateLongAKSKConfigRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateLongAKSKConfigRequestBody input)
        {
            if (input == null) return false;
            if (this.EnableLongAKSKInNewCluster != input.EnableLongAKSKInNewCluster || (this.EnableLongAKSKInNewCluster != null && !this.EnableLongAKSKInNewCluster.Equals(input.EnableLongAKSKInNewCluster))) return false;

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
                if (this.EnableLongAKSKInNewCluster != null) hashCode = hashCode * 59 + this.EnableLongAKSKInNewCluster.GetHashCode();
                return hashCode;
            }
        }
    }
}
