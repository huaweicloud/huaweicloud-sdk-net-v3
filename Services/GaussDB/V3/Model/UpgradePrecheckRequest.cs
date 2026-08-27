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
    /// **参数解释**：  实例升级预检查的请求体。  **约束限制**：  不涉及。
    /// </summary>
    public class UpgradePrecheckRequest 
    {

        /// <summary>
        /// **参数解释**：  升级预检查实例信息。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("databases_instance_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<PreCheckForUpgradeDatabasesSingleInstance> DatabasesInstanceInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpgradePrecheckRequest {\n");
            sb.Append("  databasesInstanceInfos: ").Append(DatabasesInstanceInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpgradePrecheckRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpgradePrecheckRequest input)
        {
            if (input == null) return false;
            if (this.DatabasesInstanceInfos != input.DatabasesInstanceInfos || (this.DatabasesInstanceInfos != null && input.DatabasesInstanceInfos != null && !this.DatabasesInstanceInfos.SequenceEqual(input.DatabasesInstanceInfos))) return false;

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
                if (this.DatabasesInstanceInfos != null) hashCode = hashCode * 59 + this.DatabasesInstanceInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
