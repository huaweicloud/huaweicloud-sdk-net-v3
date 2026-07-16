using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// sfsTurbo弹性文件系统输出。
    /// </summary>
    public class NFSSummary 
    {

        /// <summary>
        /// **参数解释**：sfsTurbo弹性文件系统url。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("nfs_path", NullValueHandling = NullValueHandling.Ignore)]
        public string NfsPath { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NFSSummary {\n");
            sb.Append("  nfsPath: ").Append(NfsPath).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NFSSummary);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NFSSummary input)
        {
            if (input == null) return false;
            if (this.NfsPath != input.NfsPath || (this.NfsPath != null && !this.NfsPath.Equals(input.NfsPath))) return false;

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
                if (this.NfsPath != null) hashCode = hashCode * 59 + this.NfsPath.GetHashCode();
                return hashCode;
            }
        }
    }
}
