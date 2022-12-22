using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class BatchDisassociatePublicipsResponse : SdkResponse
    {

        /// <summary>
        /// job_id列表，此job信息不保存在数据库中，不能同过组件查询到。
        /// </summary>
        [JsonProperty("job_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> JobIds { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDisassociatePublicipsResponse {\n");
            sb.Append("  jobIds: ").Append(JobIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDisassociatePublicipsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDisassociatePublicipsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JobIds == input.JobIds ||
                    this.JobIds != null &&
                    input.JobIds != null &&
                    this.JobIds.SequenceEqual(input.JobIds)
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
                if (this.JobIds != null)
                    hashCode = hashCode * 59 + this.JobIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
