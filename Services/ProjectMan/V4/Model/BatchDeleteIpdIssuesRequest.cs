using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class BatchDeleteIpdIssuesRequest 
    {

        /// <summary>
        /// 项目32位ID，项目唯一标识。通过查询IPD项目列表获取，响应消息体中的id字段的值就是项目ID。
        /// </summary>
        [SDKProperty("project_id", IsPath = true)]
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释**： 是否永久删除。 **约束限制**： 不涉及。 **取值范围**： - true：彻底删除工作项（适用于回收站中的工作项，彻底删除后不可恢复）。 - false：将工作项移入回收站。 **默认取值**： false。
        /// </summary>
        [SDKProperty("is_permanent_delete", IsQuery = true)]
        [JsonProperty("is_permanent_delete", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPermanentDelete { get; set; }

        /// <summary>
        /// **参数解释**： 当工作项类型为RR或Bug时，工作项的提出项目ID。通过[查询IPD项目列表](ShowIpdProjectList.xml)获取，响应消息体中的**id**字段的值就是项目ID。 **约束限制**： 归属项目和提出项目一致时可不传。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("src_project_id", IsQuery = true)]
        [JsonProperty("src_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteIpdIssuesRequest {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  isPermanentDelete: ").Append(IsPermanentDelete).Append("\n");
            sb.Append("  srcProjectId: ").Append(SrcProjectId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteIpdIssuesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteIpdIssuesRequest input)
        {
            if (input == null) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.IsPermanentDelete != input.IsPermanentDelete || (this.IsPermanentDelete != null && !this.IsPermanentDelete.Equals(input.IsPermanentDelete))) return false;
            if (this.SrcProjectId != input.SrcProjectId || (this.SrcProjectId != null && !this.SrcProjectId.Equals(input.SrcProjectId))) return false;
            if (this.Body != input.Body || (this.Body != null && input.Body != null && !this.Body.SequenceEqual(input.Body))) return false;

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
                if (this.IsPermanentDelete != null) hashCode = hashCode * 59 + this.IsPermanentDelete.GetHashCode();
                if (this.SrcProjectId != null) hashCode = hashCode * 59 + this.SrcProjectId.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
