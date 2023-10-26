using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V1.Model
{
    /// <summary>
    /// 脚本版本的详细信息。
    /// </summary>
    public class ScriptVersion 
    {

        /// <summary>
        /// 脚本内容，脚本内容不能为空
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        /// <summary>
        /// 创建人，比如为：张三
        /// </summary>
        [JsonProperty("create_by", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateBy { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 企业项目id
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 脚本名称，支持数字，下划线，大小写字母 ,中文
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 租户从IAM申请到的projectid，一般为32位字符串
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 脚本版本的引用次数，脚本版本被作业引用的次数。默认是0次,引用次数为非负整数，不能出现负数
        /// </summary>
        [JsonProperty("job_reference_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? JobReferenceNumber { get; set; }

        /// <summary>
        /// 脚本id，根据UUID.randomUUID生成。
        /// </summary>
        [JsonProperty("script_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptId { get; set; }

        /// <summary>
        /// 脚本语言，目前支持四种，分别是：SHELL BAT PYTHON POWER_SHELL
        /// </summary>
        [JsonProperty("script_language", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptLanguage { get; set; }

        /// <summary>
        /// 状态说明  0代表 未上线，1代表已上线  2代表已下线   3代表已禁用
        /// </summary>
        [JsonProperty("status_desc", NullValueHandling = NullValueHandling.Ignore)]
        public int? StatusDesc { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        [JsonProperty("update_by", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateBy { get; set; }

        /// <summary>
        /// 实体的最后更新时间戳。 注意：执行创建/修改/删除操作时，update_time将更新。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTime { get; set; }

        /// <summary>
        /// 版本id，根据UUID.randomUUID生成。
        /// </summary>
        [JsonProperty("version_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionId { get; set; }

        /// <summary>
        /// 脚本版本号，支持数字，下划线，大小写字母和小数点
        /// </summary>
        [JsonProperty("version_number", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionNumber { get; set; }

        /// <summary>
        /// 脚本引用的作业详情
        /// </summary>
        [JsonProperty("job_reference_name", NullValueHandling = NullValueHandling.Ignore)]
        public List<ReferenceInfo> JobReferenceName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScriptVersion {\n");
            sb.Append("  content: ").Append(Content).Append("\n");
            sb.Append("  createBy: ").Append(CreateBy).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  jobReferenceNumber: ").Append(JobReferenceNumber).Append("\n");
            sb.Append("  scriptId: ").Append(ScriptId).Append("\n");
            sb.Append("  scriptLanguage: ").Append(ScriptLanguage).Append("\n");
            sb.Append("  statusDesc: ").Append(StatusDesc).Append("\n");
            sb.Append("  updateBy: ").Append(UpdateBy).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  versionId: ").Append(VersionId).Append("\n");
            sb.Append("  versionNumber: ").Append(VersionNumber).Append("\n");
            sb.Append("  jobReferenceName: ").Append(JobReferenceName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScriptVersion);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScriptVersion input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.CreateBy == input.CreateBy ||
                    (this.CreateBy != null &&
                    this.CreateBy.Equals(input.CreateBy))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.JobReferenceNumber == input.JobReferenceNumber ||
                    (this.JobReferenceNumber != null &&
                    this.JobReferenceNumber.Equals(input.JobReferenceNumber))
                ) && 
                (
                    this.ScriptId == input.ScriptId ||
                    (this.ScriptId != null &&
                    this.ScriptId.Equals(input.ScriptId))
                ) && 
                (
                    this.ScriptLanguage == input.ScriptLanguage ||
                    (this.ScriptLanguage != null &&
                    this.ScriptLanguage.Equals(input.ScriptLanguage))
                ) && 
                (
                    this.StatusDesc == input.StatusDesc ||
                    (this.StatusDesc != null &&
                    this.StatusDesc.Equals(input.StatusDesc))
                ) && 
                (
                    this.UpdateBy == input.UpdateBy ||
                    (this.UpdateBy != null &&
                    this.UpdateBy.Equals(input.UpdateBy))
                ) && 
                (
                    this.UpdateTime == input.UpdateTime ||
                    (this.UpdateTime != null &&
                    this.UpdateTime.Equals(input.UpdateTime))
                ) && 
                (
                    this.VersionId == input.VersionId ||
                    (this.VersionId != null &&
                    this.VersionId.Equals(input.VersionId))
                ) && 
                (
                    this.VersionNumber == input.VersionNumber ||
                    (this.VersionNumber != null &&
                    this.VersionNumber.Equals(input.VersionNumber))
                ) && 
                (
                    this.JobReferenceName == input.JobReferenceName ||
                    this.JobReferenceName != null &&
                    input.JobReferenceName != null &&
                    this.JobReferenceName.SequenceEqual(input.JobReferenceName)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.CreateBy != null)
                    hashCode = hashCode * 59 + this.CreateBy.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.JobReferenceNumber != null)
                    hashCode = hashCode * 59 + this.JobReferenceNumber.GetHashCode();
                if (this.ScriptId != null)
                    hashCode = hashCode * 59 + this.ScriptId.GetHashCode();
                if (this.ScriptLanguage != null)
                    hashCode = hashCode * 59 + this.ScriptLanguage.GetHashCode();
                if (this.StatusDesc != null)
                    hashCode = hashCode * 59 + this.StatusDesc.GetHashCode();
                if (this.UpdateBy != null)
                    hashCode = hashCode * 59 + this.UpdateBy.GetHashCode();
                if (this.UpdateTime != null)
                    hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.VersionId != null)
                    hashCode = hashCode * 59 + this.VersionId.GetHashCode();
                if (this.VersionNumber != null)
                    hashCode = hashCode * 59 + this.VersionNumber.GetHashCode();
                if (this.JobReferenceName != null)
                    hashCode = hashCode * 59 + this.JobReferenceName.GetHashCode();
                return hashCode;
            }
        }
    }
}
