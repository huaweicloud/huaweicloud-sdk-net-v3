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
    /// 仪表盘分组列表。
    /// </summary>
    public class DashBoardsFolder 
    {

        /// <summary>
        /// 仪表盘分组创建时间。
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public long? Created { get; set; }

        /// <summary>
        /// 仪表盘分组更新时间。
        /// </summary>
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public long? Updated { get; set; }

        /// <summary>
        /// 仪表盘分组创建账号。
        /// </summary>
        [JsonProperty("created_by", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// 仪表盘分组下仪表盘id列表。
        /// </summary>
        [JsonProperty("dashboard_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DashboardIds { get; set; }

        /// <summary>
        /// 是否展示仪表盘分组。
        /// </summary>
        [JsonProperty("display", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Display { get; set; }

        /// <summary>
        /// 企业项目id。获取方式请参见：[获取企业项目ID](aom_04_0024.xml)。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 仪表盘分组id。
        /// </summary>
        [JsonProperty("folder_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FolderId { get; set; }

        /// <summary>
        /// 仪表盘分组名称。
        /// </summary>
        [JsonProperty("folder_title", NullValueHandling = NullValueHandling.Ignore)]
        public string FolderTitle { get; set; }

        /// <summary>
        /// 仪表盘分组英文名称。
        /// </summary>
        [JsonProperty("folder_title_en", NullValueHandling = NullValueHandling.Ignore)]
        public string FolderTitleEn { get; set; }

        /// <summary>
        /// 仪表盘分组是否为默认仪表盘分组。
        /// </summary>
        [JsonProperty("is_template", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsTemplate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DashBoardsFolder {\n");
            sb.Append("  created: ").Append(Created).Append("\n");
            sb.Append("  updated: ").Append(Updated).Append("\n");
            sb.Append("  createdBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  dashboardIds: ").Append(DashboardIds).Append("\n");
            sb.Append("  display: ").Append(Display).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  folderId: ").Append(FolderId).Append("\n");
            sb.Append("  folderTitle: ").Append(FolderTitle).Append("\n");
            sb.Append("  folderTitleEn: ").Append(FolderTitleEn).Append("\n");
            sb.Append("  isTemplate: ").Append(IsTemplate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DashBoardsFolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DashBoardsFolder input)
        {
            if (input == null) return false;
            if (this.Created != input.Created || (this.Created != null && !this.Created.Equals(input.Created))) return false;
            if (this.Updated != input.Updated || (this.Updated != null && !this.Updated.Equals(input.Updated))) return false;
            if (this.CreatedBy != input.CreatedBy || (this.CreatedBy != null && !this.CreatedBy.Equals(input.CreatedBy))) return false;
            if (this.DashboardIds != input.DashboardIds || (this.DashboardIds != null && input.DashboardIds != null && !this.DashboardIds.SequenceEqual(input.DashboardIds))) return false;
            if (this.Display != input.Display || (this.Display != null && !this.Display.Equals(input.Display))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.FolderId != input.FolderId || (this.FolderId != null && !this.FolderId.Equals(input.FolderId))) return false;
            if (this.FolderTitle != input.FolderTitle || (this.FolderTitle != null && !this.FolderTitle.Equals(input.FolderTitle))) return false;
            if (this.FolderTitleEn != input.FolderTitleEn || (this.FolderTitleEn != null && !this.FolderTitleEn.Equals(input.FolderTitleEn))) return false;
            if (this.IsTemplate != input.IsTemplate || (this.IsTemplate != null && !this.IsTemplate.Equals(input.IsTemplate))) return false;

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
                if (this.Created != null) hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Updated != null) hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.CreatedBy != null) hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.DashboardIds != null) hashCode = hashCode * 59 + this.DashboardIds.GetHashCode();
                if (this.Display != null) hashCode = hashCode * 59 + this.Display.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.FolderId != null) hashCode = hashCode * 59 + this.FolderId.GetHashCode();
                if (this.FolderTitle != null) hashCode = hashCode * 59 + this.FolderTitle.GetHashCode();
                if (this.FolderTitleEn != null) hashCode = hashCode * 59 + this.FolderTitleEn.GetHashCode();
                if (this.IsTemplate != null) hashCode = hashCode * 59 + this.IsTemplate.GetHashCode();
                return hashCode;
            }
        }
    }
}
