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
    public class ShowIpdFieldsV2Request 
    {

        /// <summary>
        /// 项目32位ID，项目唯一标识。通过查询IPD项目列表获取，响应消息体中的id字段的值就是项目ID。
        /// </summary>
        [SDKProperty("project_id", IsPath = true)]
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 工作项类型ID，工作项类型的唯一标识。 不同项目模型下可选值不同： - IPD-系统设备类：10021（RR）、10065（SF）、10020（IR）、10022（SR）、10029（AR）、10027（Task）、10033（Bug） - IPD-独立软件类：10021（RR）、10065（SF）、10020（IR）、10023（US）、10027（Task）、10033（Bug） - IPD-自运营软件/云服务类：10001（Epic）、10028（FE）、10021（RR）、10023（US）、10027（Task）、10033（Bug）
        /// </summary>
        [SDKProperty("category_id", IsPath = true)]
        [JsonProperty("category_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryId { get; set; }

        /// <summary>
        /// 层级字段ID。用于过滤层级类型的字段，当需要按层级结构筛选字段时传入。
        /// </summary>
        [SDKProperty("category_layer_id", IsQuery = true)]
        [JsonProperty("category_layer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryLayerId { get; set; }

        /// <summary>
        /// 目标项目32位ID，项目唯一标识。通过查询IPD项目列表获取，响应消息体中的id字段的值就是项目ID。当需要查询其他项目的字段配置时传入。
        /// </summary>
        [SDKProperty("target_project_id", IsQuery = true)]
        [JsonProperty("target_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowIpdFieldsV2Request {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  categoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  categoryLayerId: ").Append(CategoryLayerId).Append("\n");
            sb.Append("  targetProjectId: ").Append(TargetProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowIpdFieldsV2Request);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowIpdFieldsV2Request input)
        {
            if (input == null) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.CategoryId != input.CategoryId || (this.CategoryId != null && !this.CategoryId.Equals(input.CategoryId))) return false;
            if (this.CategoryLayerId != input.CategoryLayerId || (this.CategoryLayerId != null && !this.CategoryLayerId.Equals(input.CategoryLayerId))) return false;
            if (this.TargetProjectId != input.TargetProjectId || (this.TargetProjectId != null && !this.TargetProjectId.Equals(input.TargetProjectId))) return false;

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
                if (this.CategoryId != null) hashCode = hashCode * 59 + this.CategoryId.GetHashCode();
                if (this.CategoryLayerId != null) hashCode = hashCode * 59 + this.CategoryLayerId.GetHashCode();
                if (this.TargetProjectId != null) hashCode = hashCode * 59 + this.TargetProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
