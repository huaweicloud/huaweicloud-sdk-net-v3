using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// job_ids列表
    /// </summary>
    public class UpdateKeystoreRequestBody 
    {

        /// <summary>
        /// 文件ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 文件描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        [JsonProperty("keystore_name", NullValueHandling = NullValueHandling.Ignore)]
        public string KeystoreName { get; set; }

        /// <summary>
        /// 是否租户内共享，1-共享，0-不共享
        /// </summary>
        [JsonProperty("share", NullValueHandling = NullValueHandling.Ignore)]
        public int? Share { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateKeystoreRequestBody {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  keystoreName: ").Append(KeystoreName).Append("\n");
            sb.Append("  share: ").Append(Share).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateKeystoreRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateKeystoreRequestBody input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.KeystoreName != input.KeystoreName || (this.KeystoreName != null && !this.KeystoreName.Equals(input.KeystoreName))) return false;
            if (this.Share != input.Share || (this.Share != null && !this.Share.Equals(input.Share))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.KeystoreName != null) hashCode = hashCode * 59 + this.KeystoreName.GetHashCode();
                if (this.Share != null) hashCode = hashCode * 59 + this.Share.GetHashCode();
                return hashCode;
            }
        }
    }
}
