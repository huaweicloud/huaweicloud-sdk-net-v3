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
    public class BatchRestoreDatabaseResponse : SdkResponse
    {

        /// <summary>
        /// 表信息
        /// </summary>
        [JsonProperty("restore_result", NullValueHandling = NullValueHandling.Ignore)]
        public List<RestoreResult> RestoreResult { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchRestoreDatabaseResponse {\n");
            sb.Append("  restoreResult: ").Append(RestoreResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchRestoreDatabaseResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchRestoreDatabaseResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RestoreResult == input.RestoreResult ||
                    this.RestoreResult != null &&
                    input.RestoreResult != null &&
                    this.RestoreResult.SequenceEqual(input.RestoreResult)
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
                if (this.RestoreResult != null)
                    hashCode = hashCode * 59 + this.RestoreResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
