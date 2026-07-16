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
    /// obs并行文件系统输出。
    /// </summary>
    public class PFSSummaryResp 
    {

        /// <summary>
        /// **参数解释**：obs并行文件系统路径url。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("pfs_path", NullValueHandling = NullValueHandling.Ignore)]
        public string PfsPath { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PFSSummaryResp {\n");
            sb.Append("  pfsPath: ").Append(PfsPath).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PFSSummaryResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PFSSummaryResp input)
        {
            if (input == null) return false;
            if (this.PfsPath != input.PfsPath || (this.PfsPath != null && !this.PfsPath.Equals(input.PfsPath))) return false;

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
                if (this.PfsPath != null) hashCode = hashCode * 59 + this.PfsPath.GetHashCode();
                return hashCode;
            }
        }
    }
}
