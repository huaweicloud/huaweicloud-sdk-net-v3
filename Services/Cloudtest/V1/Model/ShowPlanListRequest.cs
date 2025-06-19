using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowPlanListRequest 
    {

        /// <summary>
        /// 用户Token。 通过调用IAM服务获取用户Token接口获取（响应消息头中X-Subject-Token的值）。
        /// </summary>
        [SDKProperty("X-Auth-Token", IsHeader = true)]
        [JsonProperty("X-Auth-Token", NullValueHandling = NullValueHandling.Ignore)]
        public string XAuthToken { get; set; }

        /// <summary>
        /// 项目id，项目唯一标识，固定长度32位字符
        /// </summary>
        [SDKProperty("project_id", IsPath = true)]
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 起始偏移量，表示从此偏移量开始查询， offset大于等于0
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public long? Offset { get; set; }

        /// <summary>
        /// 每页显示的条目数量,最大支持200条
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public long? Limit { get; set; }

        /// <summary>
        /// 模糊查询使用(针对测试计划名称)
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 测试计划所处阶段（create,design,execute,report）
        /// </summary>
        [SDKProperty("current_stage", IsQuery = true)]
        [JsonProperty("current_stage", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentStage { get; set; }

        /// <summary>
        /// 分支Uri，默认master
        /// </summary>
        [SDKProperty("branch_uri", IsQuery = true)]
        [JsonProperty("branch_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchUri { get; set; }

        /// <summary>
        /// 是否查询所有版本下测试计划，默认为false。若值为true, 查询所有版本下测试计划; 若为false, 查询branch_uri指定分支下的测试计划, branch_uri为空时默认为master
        /// </summary>
        [SDKProperty("query_all_version", IsQuery = true)]
        [JsonProperty("query_all_version", NullValueHandling = NullValueHandling.Ignore)]
        public bool? QueryAllVersion { get; set; }

        /// <summary>
        /// 测试计划关联的迭代。迭代id以逗号间隔
        /// </summary>
        [SDKProperty("fix_version_ids", IsQuery = true)]
        [JsonProperty("fix_version_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string FixVersionIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowPlanListRequest {\n");
            sb.Append("  xAuthToken: ").Append(XAuthToken).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  currentStage: ").Append(CurrentStage).Append("\n");
            sb.Append("  branchUri: ").Append(BranchUri).Append("\n");
            sb.Append("  queryAllVersion: ").Append(QueryAllVersion).Append("\n");
            sb.Append("  fixVersionIds: ").Append(FixVersionIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowPlanListRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowPlanListRequest input)
        {
            if (input == null) return false;
            if (this.XAuthToken != input.XAuthToken || (this.XAuthToken != null && !this.XAuthToken.Equals(input.XAuthToken))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.CurrentStage != input.CurrentStage || (this.CurrentStage != null && !this.CurrentStage.Equals(input.CurrentStage))) return false;
            if (this.BranchUri != input.BranchUri || (this.BranchUri != null && !this.BranchUri.Equals(input.BranchUri))) return false;
            if (this.QueryAllVersion != input.QueryAllVersion || (this.QueryAllVersion != null && !this.QueryAllVersion.Equals(input.QueryAllVersion))) return false;
            if (this.FixVersionIds != input.FixVersionIds || (this.FixVersionIds != null && !this.FixVersionIds.Equals(input.FixVersionIds))) return false;

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
                if (this.XAuthToken != null) hashCode = hashCode * 59 + this.XAuthToken.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.CurrentStage != null) hashCode = hashCode * 59 + this.CurrentStage.GetHashCode();
                if (this.BranchUri != null) hashCode = hashCode * 59 + this.BranchUri.GetHashCode();
                if (this.QueryAllVersion != null) hashCode = hashCode * 59 + this.QueryAllVersion.GetHashCode();
                if (this.FixVersionIds != null) hashCode = hashCode * 59 + this.FixVersionIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
