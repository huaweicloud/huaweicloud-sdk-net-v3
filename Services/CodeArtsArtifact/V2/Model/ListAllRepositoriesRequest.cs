using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsArtifact.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListAllRepositoriesRequest 
    {

        /// <summary>
        /// 租户id
        /// </summary>
        [SDKProperty("tenant_id", IsPath = true)]
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [SDKProperty("project_id", IsPath = true)]
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 组id
        /// </summary>
        [SDKProperty("group_id", IsQuery = true)]
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [SDKProperty("page_no", IsQuery = true)]
        [JsonProperty("page_no", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageNo { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [SDKProperty("page_size", IsQuery = true)]
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 排序类型
        /// </summary>
        [SDKProperty("sort", IsQuery = true)]
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public string Sort { get; set; }

        /// <summary>
        /// 查询内容
        /// </summary>
        [SDKProperty("qname", IsQuery = true)]
        [JsonProperty("qname", NullValueHandling = NullValueHandling.Ignore)]
        public string Qname { get; set; }

        /// <summary>
        /// 仓库类型
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 仓库格式
        /// </summary>
        [SDKProperty("format", IsQuery = true)]
        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public string Format { get; set; }

        /// <summary>
        /// 仓库格式列表
        /// </summary>
        [SDKProperty("format_list", IsQuery = true)]
        [JsonProperty("format_list", NullValueHandling = NullValueHandling.Ignore)]
        public string FormatList { get; set; }

        /// <summary>
        /// 是否是回收站文件
        /// </summary>
        [SDKProperty("is_recycle_bin", IsQuery = true)]
        [JsonProperty("is_recycle_bin", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsRecycleBin { get; set; }

        /// <summary>
        /// 是否需要分页
        /// </summary>
        [SDKProperty("is_need_paging", IsQuery = true)]
        [JsonProperty("is_need_paging", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsNeedPaging { get; set; }

        /// <summary>
        /// 是否在项目中
        /// </summary>
        [SDKProperty("in_project", IsQuery = true)]
        [JsonProperty("in_project", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InProject { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAllRepositoriesRequest {\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  pageNo: ").Append(PageNo).Append("\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("  sort: ").Append(Sort).Append("\n");
            sb.Append("  qname: ").Append(Qname).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  format: ").Append(Format).Append("\n");
            sb.Append("  formatList: ").Append(FormatList).Append("\n");
            sb.Append("  isRecycleBin: ").Append(IsRecycleBin).Append("\n");
            sb.Append("  isNeedPaging: ").Append(IsNeedPaging).Append("\n");
            sb.Append("  inProject: ").Append(InProject).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAllRepositoriesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAllRepositoriesRequest input)
        {
            if (input == null) return false;
            if (this.TenantId != input.TenantId || (this.TenantId != null && !this.TenantId.Equals(input.TenantId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.PageNo != input.PageNo || (this.PageNo != null && !this.PageNo.Equals(input.PageNo))) return false;
            if (this.PageSize != input.PageSize || (this.PageSize != null && !this.PageSize.Equals(input.PageSize))) return false;
            if (this.Sort != input.Sort || (this.Sort != null && !this.Sort.Equals(input.Sort))) return false;
            if (this.Qname != input.Qname || (this.Qname != null && !this.Qname.Equals(input.Qname))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Format != input.Format || (this.Format != null && !this.Format.Equals(input.Format))) return false;
            if (this.FormatList != input.FormatList || (this.FormatList != null && !this.FormatList.Equals(input.FormatList))) return false;
            if (this.IsRecycleBin != input.IsRecycleBin || (this.IsRecycleBin != null && !this.IsRecycleBin.Equals(input.IsRecycleBin))) return false;
            if (this.IsNeedPaging != input.IsNeedPaging || (this.IsNeedPaging != null && !this.IsNeedPaging.Equals(input.IsNeedPaging))) return false;
            if (this.InProject != input.InProject || (this.InProject != null && !this.InProject.Equals(input.InProject))) return false;

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
                if (this.TenantId != null) hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.PageNo != null) hashCode = hashCode * 59 + this.PageNo.GetHashCode();
                if (this.PageSize != null) hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.Sort != null) hashCode = hashCode * 59 + this.Sort.GetHashCode();
                if (this.Qname != null) hashCode = hashCode * 59 + this.Qname.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Format != null) hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.FormatList != null) hashCode = hashCode * 59 + this.FormatList.GetHashCode();
                if (this.IsRecycleBin != null) hashCode = hashCode * 59 + this.IsRecycleBin.GetHashCode();
                if (this.IsNeedPaging != null) hashCode = hashCode * 59 + this.IsNeedPaging.GetHashCode();
                if (this.InProject != null) hashCode = hashCode * 59 + this.InProject.GetHashCode();
                return hashCode;
            }
        }
    }
}
