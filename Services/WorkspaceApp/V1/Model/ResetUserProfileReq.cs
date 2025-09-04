using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 重置userprofile参数。
    /// </summary>
    public class ResetUserProfileReq 
    {

        /// <summary>
        /// id。
        /// </summary>
        [JsonProperty("cloud_storage_assignment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudStorageAssignmentId { get; set; }

        /// <summary>
        /// 重置文件名称
        /// </summary>
        [JsonProperty("ori_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OriName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResetUserProfileReq {\n");
            sb.Append("  cloudStorageAssignmentId: ").Append(CloudStorageAssignmentId).Append("\n");
            sb.Append("  oriName: ").Append(OriName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResetUserProfileReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResetUserProfileReq input)
        {
            if (input == null) return false;
            if (this.CloudStorageAssignmentId != input.CloudStorageAssignmentId || (this.CloudStorageAssignmentId != null && !this.CloudStorageAssignmentId.Equals(input.CloudStorageAssignmentId))) return false;
            if (this.OriName != input.OriName || (this.OriName != null && !this.OriName.Equals(input.OriName))) return false;

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
                if (this.CloudStorageAssignmentId != null) hashCode = hashCode * 59 + this.CloudStorageAssignmentId.GetHashCode();
                if (this.OriName != null) hashCode = hashCode * 59 + this.OriName.GetHashCode();
                return hashCode;
            }
        }
    }
}
