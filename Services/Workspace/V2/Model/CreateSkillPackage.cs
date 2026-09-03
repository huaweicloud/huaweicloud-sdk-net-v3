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
    /// 创建企业自研技能时的技能包信息。
    /// </summary>
    public class CreateSkillPackage 
    {

        /// <summary>
        /// 版本号。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 技能包文件名（与 getUploadUrls 中的 packageName 一致），服务端据此构造 OBS 路径。
        /// </summary>
        [JsonProperty("package_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageName { get; set; }

        /// <summary>
        /// 技能包 SHA256 哈希值（前端上传前计算）。
        /// </summary>
        [JsonProperty("package_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageHash { get; set; }

        /// <summary>
        /// 技能包大小（字节），最大 104857600。
        /// </summary>
        [JsonProperty("package_size", NullValueHandling = NullValueHandling.Ignore)]
        public long? PackageSize { get; set; }

        /// <summary>
        /// OBS 存储区域信息（含上传状态）。
        /// </summary>
        [JsonProperty("regions", NullValueHandling = NullValueHandling.Ignore)]
        public List<PackageRegionWithStatusInfo> Regions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSkillPackage {\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  packageName: ").Append(PackageName).Append("\n");
            sb.Append("  packageHash: ").Append(PackageHash).Append("\n");
            sb.Append("  packageSize: ").Append(PackageSize).Append("\n");
            sb.Append("  regions: ").Append(Regions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSkillPackage);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSkillPackage input)
        {
            if (input == null) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.PackageName != input.PackageName || (this.PackageName != null && !this.PackageName.Equals(input.PackageName))) return false;
            if (this.PackageHash != input.PackageHash || (this.PackageHash != null && !this.PackageHash.Equals(input.PackageHash))) return false;
            if (this.PackageSize != input.PackageSize || (this.PackageSize != null && !this.PackageSize.Equals(input.PackageSize))) return false;
            if (this.Regions != input.Regions || (this.Regions != null && input.Regions != null && !this.Regions.SequenceEqual(input.Regions))) return false;

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
                if (this.PackageName != null) hashCode = hashCode * 59 + this.PackageName.GetHashCode();
                if (this.PackageHash != null) hashCode = hashCode * 59 + this.PackageHash.GetHashCode();
                if (this.PackageSize != null) hashCode = hashCode * 59 + this.PackageSize.GetHashCode();
                if (this.Regions != null) hashCode = hashCode * 59 + this.Regions.GetHashCode();
                return hashCode;
            }
        }
    }
}
