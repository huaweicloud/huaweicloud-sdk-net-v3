using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowDashBoardResponse : SdkResponse
    {

        /// <summary>
        /// 项目ID，可以从控制台获取，也可以从调用API处获取。获取方式请参见：[获取项目ID](aom_04_0024.xml)。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 仪表盘类型。
        /// </summary>
        [JsonProperty("dashboard_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DashboardType { get; set; }

        /// <summary>
        /// 仪表盘名称。
        /// </summary>
        [JsonProperty("dashboard_title", NullValueHandling = NullValueHandling.Ignore)]
        public string DashboardTitle { get; set; }

        /// <summary>
        /// 仪表盘英文名称。
        /// </summary>
        [JsonProperty("dashboard_title_en", NullValueHandling = NullValueHandling.Ignore)]
        public string DashboardTitleEn { get; set; }

        /// <summary>
        /// 仪表盘id。
        /// </summary>
        [JsonProperty("dashboard_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DashboardId { get; set; }

        /// <summary>
        /// 仪表盘版本。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 仪表盘企业项目id。获取方式请参见：[获取企业项目ID](aom_04_0024.xml)。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 仪表盘分组名称。
        /// </summary>
        [JsonProperty("folder_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FolderName { get; set; }

        /// <summary>
        /// 仪表盘分组id。
        /// </summary>
        [JsonProperty("folder_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FolderId { get; set; }

        /// <summary>
        /// 待同步的仪表盘数。
        /// </summary>
        [JsonProperty("sync_data", NullValueHandling = NullValueHandling.Ignore)]
        public string SyncData { get; set; }

        /// <summary>
        /// 是否创建 - false：更新 - true：创建
        /// </summary>
        [JsonProperty("is_create_action", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCreateAction { get; set; }

        /// <summary>
        /// 仪表盘标签列表。
        /// </summary>
        [JsonProperty("dashboard_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Dictionary<string, string>> DashboardTags { get; set; }

        /// <summary>
        /// 是否收藏 - true：收藏 - false：不收藏
        /// </summary>
        [JsonProperty("is_favorite", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFavorite { get; set; }

        /// <summary>
        /// 仪表盘创建时间。
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public long? Created { get; set; }

        /// <summary>
        /// 仪表盘更新时间。
        /// </summary>
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public long? Updated { get; set; }

        /// <summary>
        /// 创建仪表盘的账号名称。
        /// </summary>
        [JsonProperty("created_by", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// 更新仪表盘的账号名称。
        /// </summary>
        [JsonProperty("updated_by", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedBy { get; set; }

        /// <summary>
        /// 仪表盘图表详情。
        /// </summary>
        [JsonProperty("charts", NullValueHandling = NullValueHandling.Ignore)]
        public Object Charts { get; set; }

        /// <summary>
        /// 仪表盘变量列表。
        /// </summary>
        [JsonProperty("templating", NullValueHandling = NullValueHandling.Ignore)]
        public Object Templating { get; set; }

        /// <summary>
        /// 是否展示。
        /// </summary>
        [JsonProperty("display", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Display { get; set; }

        /// <summary>
        /// 查询总次数。
        /// </summary>
        [JsonProperty("query_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? QueryCount { get; set; }

        /// <summary>
        /// 默认查询时间范围。
        /// </summary>
        [JsonProperty("time_range", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeRange { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDashBoardResponse {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  dashboardType: ").Append(DashboardType).Append("\n");
            sb.Append("  dashboardTitle: ").Append(DashboardTitle).Append("\n");
            sb.Append("  dashboardTitleEn: ").Append(DashboardTitleEn).Append("\n");
            sb.Append("  dashboardId: ").Append(DashboardId).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  folderName: ").Append(FolderName).Append("\n");
            sb.Append("  folderId: ").Append(FolderId).Append("\n");
            sb.Append("  syncData: ").Append(SyncData).Append("\n");
            sb.Append("  isCreateAction: ").Append(IsCreateAction).Append("\n");
            sb.Append("  dashboardTags: ").Append(DashboardTags).Append("\n");
            sb.Append("  isFavorite: ").Append(IsFavorite).Append("\n");
            sb.Append("  created: ").Append(Created).Append("\n");
            sb.Append("  updated: ").Append(Updated).Append("\n");
            sb.Append("  createdBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  updatedBy: ").Append(UpdatedBy).Append("\n");
            sb.Append("  charts: ").Append(Charts).Append("\n");
            sb.Append("  templating: ").Append(Templating).Append("\n");
            sb.Append("  display: ").Append(Display).Append("\n");
            sb.Append("  queryCount: ").Append(QueryCount).Append("\n");
            sb.Append("  timeRange: ").Append(TimeRange).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDashBoardResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDashBoardResponse input)
        {
            if (input == null) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.DashboardType != input.DashboardType || (this.DashboardType != null && !this.DashboardType.Equals(input.DashboardType))) return false;
            if (this.DashboardTitle != input.DashboardTitle || (this.DashboardTitle != null && !this.DashboardTitle.Equals(input.DashboardTitle))) return false;
            if (this.DashboardTitleEn != input.DashboardTitleEn || (this.DashboardTitleEn != null && !this.DashboardTitleEn.Equals(input.DashboardTitleEn))) return false;
            if (this.DashboardId != input.DashboardId || (this.DashboardId != null && !this.DashboardId.Equals(input.DashboardId))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.FolderName != input.FolderName || (this.FolderName != null && !this.FolderName.Equals(input.FolderName))) return false;
            if (this.FolderId != input.FolderId || (this.FolderId != null && !this.FolderId.Equals(input.FolderId))) return false;
            if (this.SyncData != input.SyncData || (this.SyncData != null && !this.SyncData.Equals(input.SyncData))) return false;
            if (this.IsCreateAction != input.IsCreateAction || (this.IsCreateAction != null && !this.IsCreateAction.Equals(input.IsCreateAction))) return false;
            if (this.DashboardTags != input.DashboardTags || (this.DashboardTags != null && input.DashboardTags != null && !this.DashboardTags.SequenceEqual(input.DashboardTags))) return false;
            if (this.IsFavorite != input.IsFavorite || (this.IsFavorite != null && !this.IsFavorite.Equals(input.IsFavorite))) return false;
            if (this.Created != input.Created || (this.Created != null && !this.Created.Equals(input.Created))) return false;
            if (this.Updated != input.Updated || (this.Updated != null && !this.Updated.Equals(input.Updated))) return false;
            if (this.CreatedBy != input.CreatedBy || (this.CreatedBy != null && !this.CreatedBy.Equals(input.CreatedBy))) return false;
            if (this.UpdatedBy != input.UpdatedBy || (this.UpdatedBy != null && !this.UpdatedBy.Equals(input.UpdatedBy))) return false;
            if (this.Charts != input.Charts || (this.Charts != null && !this.Charts.Equals(input.Charts))) return false;
            if (this.Templating != input.Templating || (this.Templating != null && !this.Templating.Equals(input.Templating))) return false;
            if (this.Display != input.Display || (this.Display != null && !this.Display.Equals(input.Display))) return false;
            if (this.QueryCount != input.QueryCount || (this.QueryCount != null && !this.QueryCount.Equals(input.QueryCount))) return false;
            if (this.TimeRange != input.TimeRange || (this.TimeRange != null && !this.TimeRange.Equals(input.TimeRange))) return false;

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
                if (this.DashboardType != null) hashCode = hashCode * 59 + this.DashboardType.GetHashCode();
                if (this.DashboardTitle != null) hashCode = hashCode * 59 + this.DashboardTitle.GetHashCode();
                if (this.DashboardTitleEn != null) hashCode = hashCode * 59 + this.DashboardTitleEn.GetHashCode();
                if (this.DashboardId != null) hashCode = hashCode * 59 + this.DashboardId.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.FolderName != null) hashCode = hashCode * 59 + this.FolderName.GetHashCode();
                if (this.FolderId != null) hashCode = hashCode * 59 + this.FolderId.GetHashCode();
                if (this.SyncData != null) hashCode = hashCode * 59 + this.SyncData.GetHashCode();
                if (this.IsCreateAction != null) hashCode = hashCode * 59 + this.IsCreateAction.GetHashCode();
                if (this.DashboardTags != null) hashCode = hashCode * 59 + this.DashboardTags.GetHashCode();
                if (this.IsFavorite != null) hashCode = hashCode * 59 + this.IsFavorite.GetHashCode();
                if (this.Created != null) hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Updated != null) hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.CreatedBy != null) hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.UpdatedBy != null) hashCode = hashCode * 59 + this.UpdatedBy.GetHashCode();
                if (this.Charts != null) hashCode = hashCode * 59 + this.Charts.GetHashCode();
                if (this.Templating != null) hashCode = hashCode * 59 + this.Templating.GetHashCode();
                if (this.Display != null) hashCode = hashCode * 59 + this.Display.GetHashCode();
                if (this.QueryCount != null) hashCode = hashCode * 59 + this.QueryCount.GetHashCode();
                if (this.TimeRange != null) hashCode = hashCode * 59 + this.TimeRange.GetHashCode();
                return hashCode;
            }
        }
    }
}
