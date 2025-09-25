using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsPipeline.V2.Model
{
    /// <summary>
    /// 产物
    /// </summary>
    public class Artifact 
    {

        /// <summary>
        /// **参数解释**： 项目ID，获取方式请参见[获取项目ID](https://support.huaweicloud.com/api-codeartsrepo/codehub_api_0014.html)。 **约束限制**： 不涉及。 **取值范围**： 32位字符，由数字和字母组成。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释**： 产物名称。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 产物版本。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("artifact_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ArtifactVersion { get; set; }

        /// <summary>
        /// **参数解释**： 产物存放平台。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("upload_target", NullValueHandling = NullValueHandling.Ignore)]
        public string UploadTarget { get; set; }

        /// <summary>
        /// **参数解释**： 产物包类型，例如jar。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("artifact_package_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ArtifactPackageType { get; set; }

        /// <summary>
        /// **参数解释**： 制品仓文件存放路径。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("artifact_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string ArtifactUri { get; set; }

        /// <summary>
        /// **参数解释**： 制品仓下载链接。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("artifact_download_url_with_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ArtifactDownloadUrlWithId { get; set; }

        /// <summary>
        /// **参数解释**： 产物类型。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("artifact_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ArtifactType { get; set; }

        /// <summary>
        /// **参数解释**： 产物哈希码。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("hash_code", NullValueHandling = NullValueHandling.Ignore)]
        public List<ArtifactHashCode> HashCode { get; set; }

        /// <summary>
        /// **参数解释**： 构建任务ID。 **约束限制**： 不涉及。 **取值范围**： 32位字符，由数字和字母组成。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// **参数解释**： 构建任务编号。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("build_no", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildNo { get; set; }

        /// <summary>
        /// **参数解释**： 构建任务序号。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("daily_build_number", NullValueHandling = NullValueHandling.Ignore)]
        public string DailyBuildNumber { get; set; }

        /// <summary>
        /// **参数解释**： 产物大小。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("file_size", NullValueHandling = NullValueHandling.Ignore)]
        public string FileSize { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Artifact {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  artifactVersion: ").Append(ArtifactVersion).Append("\n");
            sb.Append("  uploadTarget: ").Append(UploadTarget).Append("\n");
            sb.Append("  artifactPackageType: ").Append(ArtifactPackageType).Append("\n");
            sb.Append("  artifactUri: ").Append(ArtifactUri).Append("\n");
            sb.Append("  artifactDownloadUrlWithId: ").Append(ArtifactDownloadUrlWithId).Append("\n");
            sb.Append("  artifactType: ").Append(ArtifactType).Append("\n");
            sb.Append("  hashCode: ").Append(HashCode).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  buildNo: ").Append(BuildNo).Append("\n");
            sb.Append("  dailyBuildNumber: ").Append(DailyBuildNumber).Append("\n");
            sb.Append("  fileSize: ").Append(FileSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Artifact);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Artifact input)
        {
            if (input == null) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ArtifactVersion != input.ArtifactVersion || (this.ArtifactVersion != null && !this.ArtifactVersion.Equals(input.ArtifactVersion))) return false;
            if (this.UploadTarget != input.UploadTarget || (this.UploadTarget != null && !this.UploadTarget.Equals(input.UploadTarget))) return false;
            if (this.ArtifactPackageType != input.ArtifactPackageType || (this.ArtifactPackageType != null && !this.ArtifactPackageType.Equals(input.ArtifactPackageType))) return false;
            if (this.ArtifactUri != input.ArtifactUri || (this.ArtifactUri != null && !this.ArtifactUri.Equals(input.ArtifactUri))) return false;
            if (this.ArtifactDownloadUrlWithId != input.ArtifactDownloadUrlWithId || (this.ArtifactDownloadUrlWithId != null && !this.ArtifactDownloadUrlWithId.Equals(input.ArtifactDownloadUrlWithId))) return false;
            if (this.ArtifactType != input.ArtifactType || (this.ArtifactType != null && !this.ArtifactType.Equals(input.ArtifactType))) return false;
            if (this.HashCode != input.HashCode || (this.HashCode != null && input.HashCode != null && !this.HashCode.SequenceEqual(input.HashCode))) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.BuildNo != input.BuildNo || (this.BuildNo != null && !this.BuildNo.Equals(input.BuildNo))) return false;
            if (this.DailyBuildNumber != input.DailyBuildNumber || (this.DailyBuildNumber != null && !this.DailyBuildNumber.Equals(input.DailyBuildNumber))) return false;
            if (this.FileSize != input.FileSize || (this.FileSize != null && !this.FileSize.Equals(input.FileSize))) return false;

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
                if (this.ArtifactVersion != null) hashCode = hashCode * 59 + this.ArtifactVersion.GetHashCode();
                if (this.UploadTarget != null) hashCode = hashCode * 59 + this.UploadTarget.GetHashCode();
                if (this.ArtifactPackageType != null) hashCode = hashCode * 59 + this.ArtifactPackageType.GetHashCode();
                if (this.ArtifactUri != null) hashCode = hashCode * 59 + this.ArtifactUri.GetHashCode();
                if (this.ArtifactDownloadUrlWithId != null) hashCode = hashCode * 59 + this.ArtifactDownloadUrlWithId.GetHashCode();
                if (this.ArtifactType != null) hashCode = hashCode * 59 + this.ArtifactType.GetHashCode();
                if (this.HashCode != null) hashCode = hashCode * 59 + this.HashCode.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.BuildNo != null) hashCode = hashCode * 59 + this.BuildNo.GetHashCode();
                if (this.DailyBuildNumber != null) hashCode = hashCode * 59 + this.DailyBuildNumber.GetHashCode();
                if (this.FileSize != null) hashCode = hashCode * 59 + this.FileSize.GetHashCode();
                return hashCode;
            }
        }
    }
}
