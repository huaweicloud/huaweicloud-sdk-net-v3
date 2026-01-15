using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 云存储。
    /// </summary>
    public class PoliciesCloudStorage 
    {

        /// <summary>
        /// 是否开启云存储。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("cloud_storage_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CloudStorageEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public PoliciesCloudStorageOptions Options { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesCloudStorage {\n");
            sb.Append("  cloudStorageEnable: ").Append(CloudStorageEnable).Append("\n");
            sb.Append("  options: ").Append(Options).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesCloudStorage);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesCloudStorage input)
        {
            if (input == null) return false;
            if (this.CloudStorageEnable != input.CloudStorageEnable || (this.CloudStorageEnable != null && !this.CloudStorageEnable.Equals(input.CloudStorageEnable))) return false;
            if (this.Options != input.Options || (this.Options != null && !this.Options.Equals(input.Options))) return false;

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
                if (this.CloudStorageEnable != null) hashCode = hashCode * 59 + this.CloudStorageEnable.GetHashCode();
                if (this.Options != null) hashCode = hashCode * 59 + this.Options.GetHashCode();
                return hashCode;
            }
        }
    }
}
