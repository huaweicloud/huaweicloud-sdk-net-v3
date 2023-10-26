using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AdditionalBackupRequest 
    {

        /// <summary>
        /// 是否高级备份
        /// </summary>
        [JsonProperty("is_additional_backup", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAdditionalBackup { get; set; }

        /// <summary>
        /// 节点ID
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdditionalBackupRequest {\n");
            sb.Append("  isAdditionalBackup: ").Append(IsAdditionalBackup).Append("\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AdditionalBackupRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AdditionalBackupRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsAdditionalBackup == input.IsAdditionalBackup ||
                    (this.IsAdditionalBackup != null &&
                    this.IsAdditionalBackup.Equals(input.IsAdditionalBackup))
                ) && 
                (
                    this.NodeId == input.NodeId ||
                    (this.NodeId != null &&
                    this.NodeId.Equals(input.NodeId))
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
                if (this.IsAdditionalBackup != null)
                    hashCode = hashCode * 59 + this.IsAdditionalBackup.GetHashCode();
                if (this.NodeId != null)
                    hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                return hashCode;
            }
        }
    }
}
