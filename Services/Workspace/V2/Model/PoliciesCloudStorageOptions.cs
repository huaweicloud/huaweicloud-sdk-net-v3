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
    /// 云存储设置项。
    /// </summary>
    public class PoliciesCloudStorageOptions 
    {

        /// <summary>
        /// 挂盘路径。json格式，长度不能超过500000个字符。
        /// </summary>
        [JsonProperty("cloud_storage_rule", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudStorageRule { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesCloudStorageOptions {\n");
            sb.Append("  cloudStorageRule: ").Append(CloudStorageRule).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesCloudStorageOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesCloudStorageOptions input)
        {
            if (input == null) return false;
            if (this.CloudStorageRule != input.CloudStorageRule || (this.CloudStorageRule != null && !this.CloudStorageRule.Equals(input.CloudStorageRule))) return false;

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
                if (this.CloudStorageRule != null) hashCode = hashCode * 59 + this.CloudStorageRule.GetHashCode();
                return hashCode;
            }
        }
    }
}
