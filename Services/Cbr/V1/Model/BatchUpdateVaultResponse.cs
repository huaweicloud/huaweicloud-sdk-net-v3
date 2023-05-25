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
    /// Response Object
    /// </summary>
    public class BatchUpdateVaultResponse : SdkResponse
    {

        /// <summary>
        /// 已批量修改id列表
        /// </summary>
        [JsonProperty("updated_vaults_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UpdatedVaultsId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchUpdateVaultResponse {\n");
            sb.Append("  updatedVaultsId: ").Append(UpdatedVaultsId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchUpdateVaultResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchUpdateVaultResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UpdatedVaultsId == input.UpdatedVaultsId ||
                    this.UpdatedVaultsId != null &&
                    input.UpdatedVaultsId != null &&
                    this.UpdatedVaultsId.SequenceEqual(input.UpdatedVaultsId)
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
                if (this.UpdatedVaultsId != null)
                    hashCode = hashCode * 59 + this.UpdatedVaultsId.GetHashCode();
                return hashCode;
            }
        }
    }
}
