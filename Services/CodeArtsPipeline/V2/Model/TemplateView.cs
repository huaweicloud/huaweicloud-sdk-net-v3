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
    /// 流水线创建状态响应体
    /// </summary>
    public class TemplateView 
    {

        /// <summary>
        /// 模板ID
        /// </summary>
        [JsonProperty("template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 模板名字
        /// </summary>
        [JsonProperty("template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateName { get; set; }

        /// <summary>
        /// 模板类型
        /// </summary>
        [JsonProperty("template_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateType { get; set; }

        /// <summary>
        /// 模板编辑URL
        /// </summary>
        [JsonProperty("template_url", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateUrl { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 用户名字
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 租户名字
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// 是否内置模板
        /// </summary>
        [JsonProperty("is_build_in", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsBuildIn { get; set; }

        /// <summary>
        /// 系统模板region为Cloud Pipeline。自定义模板region为实际region
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 项目名字
        /// </summary>
        [JsonProperty("project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("last_modify_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastModifyTime { get; set; }

        /// <summary>
        /// 是否关注
        /// </summary>
        [JsonProperty("is_watch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsWatch { get; set; }

        /// <summary>
        /// 模板描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 模板参数
        /// </summary>
        [JsonProperty("parameter", NullValueHandling = NullValueHandling.Ignore)]
        public List<TemplateParam> Parameter { get; set; }

        /// <summary>
        /// 编排flow详情，描述流水线内各阶段任务的串并行关系。map类型数据，key为阶段名字，默认第一阶段initial，最后阶段为final，其余名字以&#39;state_数字&#39;标识。value为该阶段内任务(以&#39;Task_数字&#39;标识)以及后续阶段的标识。本字段为描述流水线基础编排数据之一，建议可通过流水线真实界面基于模板创建接口中获取
        /// </summary>
        [JsonProperty("flow", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Dictionary<string, string>> Flow { get; set; }

        /// <summary>
        /// 编排State详情，map类型数据。本字段为描述流水线基础编排数据之一，建议可通过流水线真实界面基于模板创建接口中获取
        /// </summary>
        [JsonProperty("states", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, TemplateState> States { get; set; }

        /// <summary>
        /// 是否可以修改
        /// </summary>
        [JsonProperty("can_update", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanUpdate { get; set; }

        /// <summary>
        /// 是否可以删除
        /// </summary>
        [JsonProperty("can_delete", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanDelete { get; set; }

        /// <summary>
        /// 是否需要代码仓库
        /// </summary>
        [JsonProperty("need_hub", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NeedHub { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateView {\n");
            sb.Append("  templateId: ").Append(TemplateId).Append("\n");
            sb.Append("  templateName: ").Append(TemplateName).Append("\n");
            sb.Append("  templateType: ").Append(TemplateType).Append("\n");
            sb.Append("  templateUrl: ").Append(TemplateUrl).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  isBuildIn: ").Append(IsBuildIn).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  projectName: ").Append(ProjectName).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  lastModifyTime: ").Append(LastModifyTime).Append("\n");
            sb.Append("  isWatch: ").Append(IsWatch).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  Parameter: ").Append(Parameter).Append("\n");
            sb.Append("  flow: ").Append(Flow).Append("\n");
            sb.Append("  states: ").Append(States).Append("\n");
            sb.Append("  canUpdate: ").Append(CanUpdate).Append("\n");
            sb.Append("  canDelete: ").Append(CanDelete).Append("\n");
            sb.Append("  needHub: ").Append(NeedHub).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TemplateView);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TemplateView input)
        {
            if (input == null) return false;
            if (this.TemplateId != input.TemplateId || (this.TemplateId != null && !this.TemplateId.Equals(input.TemplateId))) return false;
            if (this.TemplateName != input.TemplateName || (this.TemplateName != null && !this.TemplateName.Equals(input.TemplateName))) return false;
            if (this.TemplateType != input.TemplateType || (this.TemplateType != null && !this.TemplateType.Equals(input.TemplateType))) return false;
            if (this.TemplateUrl != input.TemplateUrl || (this.TemplateUrl != null && !this.TemplateUrl.Equals(input.TemplateUrl))) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.DomainName != input.DomainName || (this.DomainName != null && !this.DomainName.Equals(input.DomainName))) return false;
            if (this.IsBuildIn != input.IsBuildIn || (this.IsBuildIn != null && !this.IsBuildIn.Equals(input.IsBuildIn))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ProjectName != input.ProjectName || (this.ProjectName != null && !this.ProjectName.Equals(input.ProjectName))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.LastModifyTime != input.LastModifyTime || (this.LastModifyTime != null && !this.LastModifyTime.Equals(input.LastModifyTime))) return false;
            if (this.IsWatch != input.IsWatch || (this.IsWatch != null && !this.IsWatch.Equals(input.IsWatch))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Parameter != input.Parameter || (this.Parameter != null && input.Parameter != null && !this.Parameter.SequenceEqual(input.Parameter))) return false;
            if (this.Flow != input.Flow || (this.Flow != null && input.Flow != null && !this.Flow.SequenceEqual(input.Flow))) return false;
            if (this.States != input.States || (this.States != null && input.States != null && !this.States.SequenceEqual(input.States))) return false;
            if (this.CanUpdate != input.CanUpdate || (this.CanUpdate != null && !this.CanUpdate.Equals(input.CanUpdate))) return false;
            if (this.CanDelete != input.CanDelete || (this.CanDelete != null && !this.CanDelete.Equals(input.CanDelete))) return false;
            if (this.NeedHub != input.NeedHub || (this.NeedHub != null && !this.NeedHub.Equals(input.NeedHub))) return false;

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
                if (this.TemplateId != null) hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.TemplateName != null) hashCode = hashCode * 59 + this.TemplateName.GetHashCode();
                if (this.TemplateType != null) hashCode = hashCode * 59 + this.TemplateType.GetHashCode();
                if (this.TemplateUrl != null) hashCode = hashCode * 59 + this.TemplateUrl.GetHashCode();
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.DomainName != null) hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.IsBuildIn != null) hashCode = hashCode * 59 + this.IsBuildIn.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ProjectName != null) hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.LastModifyTime != null) hashCode = hashCode * 59 + this.LastModifyTime.GetHashCode();
                if (this.IsWatch != null) hashCode = hashCode * 59 + this.IsWatch.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Parameter != null) hashCode = hashCode * 59 + this.Parameter.GetHashCode();
                if (this.Flow != null) hashCode = hashCode * 59 + this.Flow.GetHashCode();
                if (this.States != null) hashCode = hashCode * 59 + this.States.GetHashCode();
                if (this.CanUpdate != null) hashCode = hashCode * 59 + this.CanUpdate.GetHashCode();
                if (this.CanDelete != null) hashCode = hashCode * 59 + this.CanDelete.GetHashCode();
                if (this.NeedHub != null) hashCode = hashCode * 59 + this.NeedHub.GetHashCode();
                return hashCode;
            }
        }
    }
}
