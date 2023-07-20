using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class BatchDeleteManualBackupResponse : SdkResponse
    {

        /// <summary>
        /// 备份删除结果
        /// </summary>
        [JsonProperty("delete_results", NullValueHandling = NullValueHandling.Ignore)]
        public List<DeleteBackupResult> DeleteResults { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteManualBackupResponse {\n");
            sb.Append("  deleteResults: ").Append(DeleteResults).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteManualBackupResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteManualBackupResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeleteResults == input.DeleteResults ||
                    this.DeleteResults != null &&
                    input.DeleteResults != null &&
                    this.DeleteResults.SequenceEqual(input.DeleteResults)
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
                if (this.DeleteResults != null)
                    hashCode = hashCode * 59 + this.DeleteResults.GetHashCode();
                return hashCode;
            }
        }
    }
}
