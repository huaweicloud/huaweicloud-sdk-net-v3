using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SyncRespBody 
    {

        /// <summary>
        /// 是否自动触发
        /// </summary>
        [JsonProperty("operation_log_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationLogId { get; set; }

        /// <summary>
        /// 混合云vault id
        /// </summary>
        [JsonProperty("vault_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VaultId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SyncRespBody {\n");
            sb.Append("  operationLogId: ").Append(OperationLogId).Append("\n");
            sb.Append("  vaultId: ").Append(VaultId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SyncRespBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SyncRespBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OperationLogId == input.OperationLogId ||
                    (this.OperationLogId != null &&
                    this.OperationLogId.Equals(input.OperationLogId))
                ) && 
                (
                    this.VaultId == input.VaultId ||
                    (this.VaultId != null &&
                    this.VaultId.Equals(input.VaultId))
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
                if (this.OperationLogId != null)
                    hashCode = hashCode * 59 + this.OperationLogId.GetHashCode();
                if (this.VaultId != null)
                    hashCode = hashCode * 59 + this.VaultId.GetHashCode();
                return hashCode;
            }
        }
    }
}
