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
    /// 操作系统详情
    /// </summary>
    public class OsVersionInfo 
    {

        /// <summary>
        /// 操作系统的平台值
        /// </summary>
        [JsonProperty("platform", NullValueHandling = NullValueHandling.Ignore)]
        public string Platform { get; set; }

        /// <summary>
        /// os_version的key值，和os_version值相同
        /// </summary>
        [JsonProperty("os_version_key", NullValueHandling = NullValueHandling.Ignore)]
        public string OsVersionKey { get; set; }

        /// <summary>
        /// 操作系统的版本
        /// </summary>
        [JsonProperty("os_version", NullValueHandling = NullValueHandling.Ignore)]
        public string OsVersion { get; set; }

        /// <summary>
        /// 操作系统的位数
        /// </summary>
        [JsonProperty("os_bit", NullValueHandling = NullValueHandling.Ignore)]
        public int? OsBit { get; set; }

        /// <summary>
        /// 操作系统的类型，Linux或Windows
        /// </summary>
        [JsonProperty("os_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OsType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OsVersionInfo {\n");
            sb.Append("  platform: ").Append(Platform).Append("\n");
            sb.Append("  osVersionKey: ").Append(OsVersionKey).Append("\n");
            sb.Append("  osVersion: ").Append(OsVersion).Append("\n");
            sb.Append("  osBit: ").Append(OsBit).Append("\n");
            sb.Append("  osType: ").Append(OsType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OsVersionInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OsVersionInfo input)
        {
            if (input == null) return false;
            if (this.Platform != input.Platform || (this.Platform != null && !this.Platform.Equals(input.Platform))) return false;
            if (this.OsVersionKey != input.OsVersionKey || (this.OsVersionKey != null && !this.OsVersionKey.Equals(input.OsVersionKey))) return false;
            if (this.OsVersion != input.OsVersion || (this.OsVersion != null && !this.OsVersion.Equals(input.OsVersion))) return false;
            if (this.OsBit != input.OsBit || (this.OsBit != null && !this.OsBit.Equals(input.OsBit))) return false;
            if (this.OsType != input.OsType || (this.OsType != null && !this.OsType.Equals(input.OsType))) return false;

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
                if (this.OsVersionKey != null) hashCode = hashCode * 59 + this.OsVersionKey.GetHashCode();
                if (this.OsVersion != null) hashCode = hashCode * 59 + this.OsVersion.GetHashCode();
                if (this.OsBit != null) hashCode = hashCode * 59 + this.OsBit.GetHashCode();
                if (this.OsType != null) hashCode = hashCode * 59 + this.OsType.GetHashCode();
                return hashCode;
            }
        }
    }
}
