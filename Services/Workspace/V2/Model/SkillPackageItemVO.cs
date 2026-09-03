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
    /// 技能包列表项响应。
    /// </summary>
    public class SkillPackageItemVO 
    {

        /// <summary>
        /// 技能包id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 版本号。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 版本修订号。
        /// </summary>
        [JsonProperty("revision", NullValueHandling = NullValueHandling.Ignore)]
        public int? Revision { get; set; }

        /// <summary>
        /// 技能包 SHA256 哈希值。
        /// </summary>
        [JsonProperty("package_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageHash { get; set; }

        /// <summary>
        /// 技能包大小（字节）。
        /// </summary>
        [JsonProperty("package_size", NullValueHandling = NullValueHandling.Ignore)]
        public long? PackageSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("package_status", NullValueHandling = NullValueHandling.Ignore)]
        public PackageStatusEnum? PackageStatus { get; set; }

        /// <summary>
        /// 上传者。
        /// </summary>
        [JsonProperty("uploaded_by", NullValueHandling = NullValueHandling.Ignore)]
        public string UploadedBy { get; set; }

        /// <summary>
        /// 上传者角色。
        /// </summary>
        [JsonProperty("uploaded_role", NullValueHandling = NullValueHandling.Ignore)]
        public string UploadedRole { get; set; }

        /// <summary>
        /// 区域详情列表。
        /// </summary>
        [JsonProperty("regions", NullValueHandling = NullValueHandling.Ignore)]
        public List<SkillPackageRegionItem> Regions { get; set; }

        /// <summary>
        /// 备注。
        /// </summary>
        [JsonProperty("remark", NullValueHandling = NullValueHandling.Ignore)]
        public string Remark { get; set; }

        /// <summary>
        /// 创建时间（ISO8601格式，UTC时区）。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 更新时间（ISO8601格式，UTC时区）。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SkillPackageItemVO {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  revision: ").Append(Revision).Append("\n");
            sb.Append("  packageHash: ").Append(PackageHash).Append("\n");
            sb.Append("  packageSize: ").Append(PackageSize).Append("\n");
            sb.Append("  packageStatus: ").Append(PackageStatus).Append("\n");
            sb.Append("  uploadedBy: ").Append(UploadedBy).Append("\n");
            sb.Append("  uploadedRole: ").Append(UploadedRole).Append("\n");
            sb.Append("  regions: ").Append(Regions).Append("\n");
            sb.Append("  remark: ").Append(Remark).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SkillPackageItemVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SkillPackageItemVO input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.Revision != input.Revision || (this.Revision != null && !this.Revision.Equals(input.Revision))) return false;
            if (this.PackageHash != input.PackageHash || (this.PackageHash != null && !this.PackageHash.Equals(input.PackageHash))) return false;
            if (this.PackageSize != input.PackageSize || (this.PackageSize != null && !this.PackageSize.Equals(input.PackageSize))) return false;
            if (this.PackageStatus != input.PackageStatus || (this.PackageStatus != null && !this.PackageStatus.Equals(input.PackageStatus))) return false;
            if (this.UploadedBy != input.UploadedBy || (this.UploadedBy != null && !this.UploadedBy.Equals(input.UploadedBy))) return false;
            if (this.UploadedRole != input.UploadedRole || (this.UploadedRole != null && !this.UploadedRole.Equals(input.UploadedRole))) return false;
            if (this.Regions != input.Regions || (this.Regions != null && input.Regions != null && !this.Regions.SequenceEqual(input.Regions))) return false;
            if (this.Remark != input.Remark || (this.Remark != null && !this.Remark.Equals(input.Remark))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;

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
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Revision != null) hashCode = hashCode * 59 + this.Revision.GetHashCode();
                if (this.PackageHash != null) hashCode = hashCode * 59 + this.PackageHash.GetHashCode();
                if (this.PackageSize != null) hashCode = hashCode * 59 + this.PackageSize.GetHashCode();
                if (this.PackageStatus != null) hashCode = hashCode * 59 + this.PackageStatus.GetHashCode();
                if (this.UploadedBy != null) hashCode = hashCode * 59 + this.UploadedBy.GetHashCode();
                if (this.UploadedRole != null) hashCode = hashCode * 59 + this.UploadedRole.GetHashCode();
                if (this.Regions != null) hashCode = hashCode * 59 + this.Regions.GetHashCode();
                if (this.Remark != null) hashCode = hashCode * 59 + this.Remark.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
