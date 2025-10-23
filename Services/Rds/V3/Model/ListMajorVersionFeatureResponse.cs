using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListMajorVersionFeatureResponse : SdkResponse
    {

        /// <summary>
        /// 版本名称。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 支持升级的版本列表。
        /// </summary>
        [JsonProperty("support_upgrade_version", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SupportUpgradeVersion { get; set; }

        /// <summary>
        /// 支持备份恢复的版本列表。
        /// </summary>
        [JsonProperty("support_recover_version", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SupportRecoverVersion { get; set; }

        /// <summary>
        /// 是否支持FileStream特性。
        /// </summary>
        [JsonProperty("support_file_stream", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportFileStream { get; set; }

        /// <summary>
        /// 是否支持透明数据加密。
        /// </summary>
        [JsonProperty("support_tde", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportTde { get; set; }

        /// <summary>
        /// 是否支持Always On。
        /// </summary>
        [JsonProperty("support_always_on", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportAlwaysOn { get; set; }

        /// <summary>
        /// 是否支持只读。
        /// </summary>
        [JsonProperty("support_read_only", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportReadOnly { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListMajorVersionFeatureResponse {\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  supportUpgradeVersion: ").Append(SupportUpgradeVersion).Append("\n");
            sb.Append("  supportRecoverVersion: ").Append(SupportRecoverVersion).Append("\n");
            sb.Append("  supportFileStream: ").Append(SupportFileStream).Append("\n");
            sb.Append("  supportTde: ").Append(SupportTde).Append("\n");
            sb.Append("  supportAlwaysOn: ").Append(SupportAlwaysOn).Append("\n");
            sb.Append("  supportReadOnly: ").Append(SupportReadOnly).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListMajorVersionFeatureResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListMajorVersionFeatureResponse input)
        {
            if (input == null) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.SupportUpgradeVersion != input.SupportUpgradeVersion || (this.SupportUpgradeVersion != null && input.SupportUpgradeVersion != null && !this.SupportUpgradeVersion.SequenceEqual(input.SupportUpgradeVersion))) return false;
            if (this.SupportRecoverVersion != input.SupportRecoverVersion || (this.SupportRecoverVersion != null && input.SupportRecoverVersion != null && !this.SupportRecoverVersion.SequenceEqual(input.SupportRecoverVersion))) return false;
            if (this.SupportFileStream != input.SupportFileStream || (this.SupportFileStream != null && !this.SupportFileStream.Equals(input.SupportFileStream))) return false;
            if (this.SupportTde != input.SupportTde || (this.SupportTde != null && !this.SupportTde.Equals(input.SupportTde))) return false;
            if (this.SupportAlwaysOn != input.SupportAlwaysOn || (this.SupportAlwaysOn != null && !this.SupportAlwaysOn.Equals(input.SupportAlwaysOn))) return false;
            if (this.SupportReadOnly != input.SupportReadOnly || (this.SupportReadOnly != null && !this.SupportReadOnly.Equals(input.SupportReadOnly))) return false;

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
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.SupportUpgradeVersion != null) hashCode = hashCode * 59 + this.SupportUpgradeVersion.GetHashCode();
                if (this.SupportRecoverVersion != null) hashCode = hashCode * 59 + this.SupportRecoverVersion.GetHashCode();
                if (this.SupportFileStream != null) hashCode = hashCode * 59 + this.SupportFileStream.GetHashCode();
                if (this.SupportTde != null) hashCode = hashCode * 59 + this.SupportTde.GetHashCode();
                if (this.SupportAlwaysOn != null) hashCode = hashCode * 59 + this.SupportAlwaysOn.GetHashCode();
                if (this.SupportReadOnly != null) hashCode = hashCode * 59 + this.SupportReadOnly.GetHashCode();
                return hashCode;
            }
        }
    }
}
