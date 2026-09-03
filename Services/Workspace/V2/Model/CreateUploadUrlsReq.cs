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
    /// 获取 OBS 预签名上传地址请求。
    /// </summary>
    public class CreateUploadUrlsReq 
    {

        /// <summary>
        /// 技能slug（用于构建 OBS 路径）。
        /// </summary>
        [JsonProperty("slug", NullValueHandling = NullValueHandling.Ignore)]
        public string Slug { get; set; }

        /// <summary>
        /// 版本号（用于构建 OBS 路径）。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 包文件名。
        /// </summary>
        [JsonProperty("package_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageName { get; set; }

        /// <summary>
        /// 目标 region 列表。
        /// </summary>
        [JsonProperty("regions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Regions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateUploadUrlsReq {\n");
            sb.Append("  slug: ").Append(Slug).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  packageName: ").Append(PackageName).Append("\n");
            sb.Append("  regions: ").Append(Regions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateUploadUrlsReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateUploadUrlsReq input)
        {
            if (input == null) return false;
            if (this.Slug != input.Slug || (this.Slug != null && !this.Slug.Equals(input.Slug))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.PackageName != input.PackageName || (this.PackageName != null && !this.PackageName.Equals(input.PackageName))) return false;
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
                if (this.Slug != null) hashCode = hashCode * 59 + this.Slug.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.PackageName != null) hashCode = hashCode * 59 + this.PackageName.GetHashCode();
                if (this.Regions != null) hashCode = hashCode * 59 + this.Regions.GetHashCode();
                return hashCode;
            }
        }
    }
}
