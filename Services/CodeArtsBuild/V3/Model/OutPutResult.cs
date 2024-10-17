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
    /// 产物信息
    /// </summary>
    public class OutPutResult 
    {

        /// <summary>
        /// 构建任务所在项目的ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 产物名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 产物版本
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 产物类型
        /// </summary>
        [JsonProperty("package_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageType { get; set; }

        /// <summary>
        /// 产物路径
        /// </summary>
        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 构建编号，每日从1开始
        /// </summary>
        [JsonProperty("daily_build_number", NullValueHandling = NullValueHandling.Ignore)]
        public string DailyBuildNumber { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutPutResult {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  packageType: ").Append(PackageType).Append("\n");
            sb.Append("  uri: ").Append(Uri).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  dailyBuildNumber: ").Append(DailyBuildNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OutPutResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OutPutResult input)
        {
            if (input == null) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.PackageType != input.PackageType || (this.PackageType != null && !this.PackageType.Equals(input.PackageType))) return false;
            if (this.Uri != input.Uri || (this.Uri != null && !this.Uri.Equals(input.Uri))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.DailyBuildNumber != input.DailyBuildNumber || (this.DailyBuildNumber != null && !this.DailyBuildNumber.Equals(input.DailyBuildNumber))) return false;

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
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.PackageType != null) hashCode = hashCode * 59 + this.PackageType.GetHashCode();
                if (this.Uri != null) hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.DailyBuildNumber != null) hashCode = hashCode * 59 + this.DailyBuildNumber.GetHashCode();
                return hashCode;
            }
        }
    }
}
