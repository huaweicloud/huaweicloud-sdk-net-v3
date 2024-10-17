using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ims.V2.Model
{
    /// <summary>
    /// 查询操作系统列表响应体
    /// </summary>
    public class ListOsVersionsResponseBody 
    {

        /// <summary>
        /// 操作系统的平台值，如RedHat等
        /// </summary>
        [JsonProperty("platform", NullValueHandling = NullValueHandling.Ignore)]
        public string Platform { get; set; }

        /// <summary>
        /// 操作系统的详情值
        /// </summary>
        [JsonProperty("version_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<OsVersionInfo> VersionList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListOsVersionsResponseBody {\n");
            sb.Append("  platform: ").Append(Platform).Append("\n");
            sb.Append("  versionList: ").Append(VersionList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListOsVersionsResponseBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListOsVersionsResponseBody input)
        {
            if (input == null) return false;
            if (this.Platform != input.Platform || (this.Platform != null && !this.Platform.Equals(input.Platform))) return false;
            if (this.VersionList != input.VersionList || (this.VersionList != null && input.VersionList != null && !this.VersionList.SequenceEqual(input.VersionList))) return false;

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
                if (this.Platform != null) hashCode = hashCode * 59 + this.Platform.GetHashCode();
                if (this.VersionList != null) hashCode = hashCode * 59 + this.VersionList.GetHashCode();
                return hashCode;
            }
        }
    }
}
