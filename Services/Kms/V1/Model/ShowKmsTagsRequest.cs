using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kms.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowKmsTagsRequest 
    {

        /// <summary>
        /// API版本号
        /// </summary>
        [SDKProperty("version_id", IsPath = true)]
        [JsonProperty("version_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionId { get; set; }

        /// <summary>
        /// 密钥ID
        /// </summary>
        [SDKProperty("key_id", IsPath = true)]
        [JsonProperty("key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowKmsTagsRequest {\n");
            sb.Append("  versionId: ").Append(VersionId).Append("\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowKmsTagsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowKmsTagsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VersionId == input.VersionId ||
                    (this.VersionId != null &&
                    this.VersionId.Equals(input.VersionId))
                ) && 
                (
                    this.KeyId == input.KeyId ||
                    (this.KeyId != null &&
                    this.KeyId.Equals(input.KeyId))
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
                if (this.VersionId != null)
                    hashCode = hashCode * 59 + this.VersionId.GetHashCode();
                if (this.KeyId != null)
                    hashCode = hashCode * 59 + this.KeyId.GetHashCode();
                return hashCode;
            }
        }
    }
}
