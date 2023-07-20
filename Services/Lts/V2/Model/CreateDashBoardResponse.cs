using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateDashBoardResponse : SdkResponse
    {

        /// <summary>
        /// 仪表盘图表
        /// </summary>
        [JsonProperty("charts", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Charts { get; set; }

        /// <summary>
        /// 过滤条件
        /// </summary>
        [JsonProperty("filters", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Filters { get; set; }

        /// <summary>
        /// 日志组名称
        /// </summary>
        [JsonProperty("group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// 仪表盘id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 最近修改时间
        /// </summary>
        [JsonProperty("last_update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdateTime { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 仪表盘名称
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 是否使用模板
        /// </summary>
        [JsonProperty("useSystemTemplate", NullValueHandling = NullValueHandling.Ignore)]
        public string UseSystemTemplate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDashBoardResponse {\n");
            sb.Append("  charts: ").Append(Charts).Append("\n");
            sb.Append("  filters: ").Append(Filters).Append("\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  lastUpdateTime: ").Append(LastUpdateTime).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  useSystemTemplate: ").Append(UseSystemTemplate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDashBoardResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateDashBoardResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Charts == input.Charts ||
                    this.Charts != null &&
                    input.Charts != null &&
                    this.Charts.SequenceEqual(input.Charts)
                ) && 
                (
                    this.Filters == input.Filters ||
                    this.Filters != null &&
                    input.Filters != null &&
                    this.Filters.SequenceEqual(input.Filters)
                ) && 
                (
                    this.GroupName == input.GroupName ||
                    (this.GroupName != null &&
                    this.GroupName.Equals(input.GroupName))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LastUpdateTime == input.LastUpdateTime ||
                    (this.LastUpdateTime != null &&
                    this.LastUpdateTime.Equals(input.LastUpdateTime))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.UseSystemTemplate == input.UseSystemTemplate ||
                    (this.UseSystemTemplate != null &&
                    this.UseSystemTemplate.Equals(input.UseSystemTemplate))
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
                if (this.Charts != null)
                    hashCode = hashCode * 59 + this.Charts.GetHashCode();
                if (this.Filters != null)
                    hashCode = hashCode * 59 + this.Filters.GetHashCode();
                if (this.GroupName != null)
                    hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LastUpdateTime != null)
                    hashCode = hashCode * 59 + this.LastUpdateTime.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.UseSystemTemplate != null)
                    hashCode = hashCode * 59 + this.UseSystemTemplate.GetHashCode();
                return hashCode;
            }
        }
    }
}
