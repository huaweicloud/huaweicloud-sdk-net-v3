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
    /// Request Object
    /// </summary>
    public class UpdateCloudUserFolderAssignmentRequest 
    {

        /// <summary>
        /// WKS存储ID。
        /// </summary>
        [SDKProperty("storage_id", IsPath = true)]
        [JsonProperty("storage_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StorageId { get; set; }

        /// <summary>
        /// 文件夹id。
        /// </summary>
        [SDKProperty("cloud_assignment_id", IsPath = true)]
        [JsonProperty("cloud_assignment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudAssignmentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateUserFolderReq Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateCloudUserFolderAssignmentRequest {\n");
            sb.Append("  storageId: ").Append(StorageId).Append("\n");
            sb.Append("  cloudAssignmentId: ").Append(CloudAssignmentId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateCloudUserFolderAssignmentRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateCloudUserFolderAssignmentRequest input)
        {
            if (input == null) return false;
            if (this.StorageId != input.StorageId || (this.StorageId != null && !this.StorageId.Equals(input.StorageId))) return false;
            if (this.CloudAssignmentId != input.CloudAssignmentId || (this.CloudAssignmentId != null && !this.CloudAssignmentId.Equals(input.CloudAssignmentId))) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;

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
                if (this.StorageId != null) hashCode = hashCode * 59 + this.StorageId.GetHashCode();
                if (this.CloudAssignmentId != null) hashCode = hashCode * 59 + this.CloudAssignmentId.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
