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
    public class ShowProjectConfigRequest 
    {

        /// <summary>
        /// 云存储ID。
        /// </summary>
        [SDKProperty("cloud_storage_id", IsPath = true)]
        [JsonProperty("cloud_storage_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudStorageId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowProjectConfigRequest {\n");
            sb.Append("  cloudStorageId: ").Append(CloudStorageId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowProjectConfigRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowProjectConfigRequest input)
        {
            if (input == null) return false;
            if (this.CloudStorageId != input.CloudStorageId || (this.CloudStorageId != null && !this.CloudStorageId.Equals(input.CloudStorageId))) return false;

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
                if (this.CloudStorageId != null) hashCode = hashCode * 59 + this.CloudStorageId.GetHashCode();
                return hashCode;
            }
        }
    }
}
