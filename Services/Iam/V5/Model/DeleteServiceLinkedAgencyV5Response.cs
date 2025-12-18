using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class DeleteServiceLinkedAgencyV5Response : SdkResponse
    {

        /// <summary>
        /// 删除任务ID。
        /// </summary>
        [JsonProperty("deletion_task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DeletionTaskId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteServiceLinkedAgencyV5Response {\n");
            sb.Append("  deletionTaskId: ").Append(DeletionTaskId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteServiceLinkedAgencyV5Response);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteServiceLinkedAgencyV5Response input)
        {
            if (input == null) return false;
            if (this.DeletionTaskId != input.DeletionTaskId || (this.DeletionTaskId != null && !this.DeletionTaskId.Equals(input.DeletionTaskId))) return false;

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
                if (this.DeletionTaskId != null) hashCode = hashCode * 59 + this.DeletionTaskId.GetHashCode();
                return hashCode;
            }
        }
    }
}
