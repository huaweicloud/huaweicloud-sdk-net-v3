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
    /// **参数解释：** 升级前检查元数据 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及 
    /// </summary>
    public class PrecheckCluserResponseMetadata 
    {

        /// <summary>
        /// **参数解释：** 检查任务ID **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及 
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrecheckCluserResponseMetadata {\n");
            sb.Append("  uid: ").Append(Uid).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrecheckCluserResponseMetadata);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PrecheckCluserResponseMetadata input)
        {
            if (input == null) return false;
            if (this.Uid != input.Uid || (this.Uid != null && !this.Uid.Equals(input.Uid))) return false;

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
                if (this.Uid != null) hashCode = hashCode * 59 + this.Uid.GetHashCode();
                return hashCode;
            }
        }
    }
}
