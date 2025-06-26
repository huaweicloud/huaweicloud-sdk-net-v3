using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowAppDetailResponse : SdkResponse
    {

        /// <summary>
        /// 应用ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 应用名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 应用版本号。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 启动命令行参数。
        /// </summary>
        [JsonProperty("command_param", NullValueHandling = NullValueHandling.Ignore)]
        public string CommandParam { get; set; }

        /// <summary>
        /// 执行路径。
        /// </summary>
        [JsonProperty("execute_path", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutePath { get; set; }

        /// <summary>
        /// 应用工作目录。
        /// </summary>
        [JsonProperty("work_path", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkPath { get; set; }

        /// <summary>
        /// 应用图标的路径。
        /// </summary>
        [JsonProperty("icon_path", NullValueHandling = NullValueHandling.Ignore)]
        public string IconPath { get; set; }

        /// <summary>
        /// 应用图标的索引。
        /// </summary>
        [JsonProperty("icon_index", NullValueHandling = NullValueHandling.Ignore)]
        public int? IconIndex { get; set; }

        /// <summary>
        /// 应用描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 应用组标识Id。
        /// </summary>
        [JsonProperty("app_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppGroupId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public AppStateEnum State { get; set; }
        /// <summary>
        /// 所在的租户ID。
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 发布时间。
        /// </summary>
        [JsonProperty("publish_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? PublishAt { get; set; }

        /// <summary>
        /// 应用类型： - &#39;1&#39;:系统内置应用 - &#39;2&#39;:镜像应用 - &#39;3&#39;:自定义应用
        /// </summary>
        [JsonProperty("source_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? SourceType { get; set; }

        /// <summary>
        /// 应用发布者。
        /// </summary>
        [JsonProperty("publisher", NullValueHandling = NullValueHandling.Ignore)]
        public string Publisher { get; set; }

        /// <summary>
        /// 图标url。
        /// </summary>
        [JsonProperty("icon_url", NullValueHandling = NullValueHandling.Ignore)]
        public string IconUrl { get; set; }

        /// <summary>
        /// 是否可发布应用： - true: 可发布。 - false: 不可发布。
        /// </summary>
        [JsonProperty("publishable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Publishable { get; set; }

        /// <summary>
        /// 是否使用沙箱模式运行，取值为： - false: 表示不以沙箱模式运行。 - true: 表示以沙箱模式运行。
        /// </summary>
        [JsonProperty("sandbox_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SandboxEnable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAppDetailResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  commandParam: ").Append(CommandParam).Append("\n");
            sb.Append("  executePath: ").Append(ExecutePath).Append("\n");
            sb.Append("  workPath: ").Append(WorkPath).Append("\n");
            sb.Append("  iconPath: ").Append(IconPath).Append("\n");
            sb.Append("  iconIndex: ").Append(IconIndex).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  appGroupId: ").Append(AppGroupId).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  publishAt: ").Append(PublishAt).Append("\n");
            sb.Append("  sourceType: ").Append(SourceType).Append("\n");
            sb.Append("  publisher: ").Append(Publisher).Append("\n");
            sb.Append("  iconUrl: ").Append(IconUrl).Append("\n");
            sb.Append("  publishable: ").Append(Publishable).Append("\n");
            sb.Append("  sandboxEnable: ").Append(SandboxEnable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAppDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAppDetailResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.CommandParam != input.CommandParam || (this.CommandParam != null && !this.CommandParam.Equals(input.CommandParam))) return false;
            if (this.ExecutePath != input.ExecutePath || (this.ExecutePath != null && !this.ExecutePath.Equals(input.ExecutePath))) return false;
            if (this.WorkPath != input.WorkPath || (this.WorkPath != null && !this.WorkPath.Equals(input.WorkPath))) return false;
            if (this.IconPath != input.IconPath || (this.IconPath != null && !this.IconPath.Equals(input.IconPath))) return false;
            if (this.IconIndex != input.IconIndex || (this.IconIndex != null && !this.IconIndex.Equals(input.IconIndex))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.AppGroupId != input.AppGroupId || (this.AppGroupId != null && !this.AppGroupId.Equals(input.AppGroupId))) return false;
            if (this.State != input.State) return false;
            if (this.TenantId != input.TenantId || (this.TenantId != null && !this.TenantId.Equals(input.TenantId))) return false;
            if (this.PublishAt != input.PublishAt || (this.PublishAt != null && !this.PublishAt.Equals(input.PublishAt))) return false;
            if (this.SourceType != input.SourceType || (this.SourceType != null && !this.SourceType.Equals(input.SourceType))) return false;
            if (this.Publisher != input.Publisher || (this.Publisher != null && !this.Publisher.Equals(input.Publisher))) return false;
            if (this.IconUrl != input.IconUrl || (this.IconUrl != null && !this.IconUrl.Equals(input.IconUrl))) return false;
            if (this.Publishable != input.Publishable || (this.Publishable != null && !this.Publishable.Equals(input.Publishable))) return false;
            if (this.SandboxEnable != input.SandboxEnable || (this.SandboxEnable != null && !this.SandboxEnable.Equals(input.SandboxEnable))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.CommandParam != null) hashCode = hashCode * 59 + this.CommandParam.GetHashCode();
                if (this.ExecutePath != null) hashCode = hashCode * 59 + this.ExecutePath.GetHashCode();
                if (this.WorkPath != null) hashCode = hashCode * 59 + this.WorkPath.GetHashCode();
                if (this.IconPath != null) hashCode = hashCode * 59 + this.IconPath.GetHashCode();
                if (this.IconIndex != null) hashCode = hashCode * 59 + this.IconIndex.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.AppGroupId != null) hashCode = hashCode * 59 + this.AppGroupId.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.TenantId != null) hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.PublishAt != null) hashCode = hashCode * 59 + this.PublishAt.GetHashCode();
                if (this.SourceType != null) hashCode = hashCode * 59 + this.SourceType.GetHashCode();
                if (this.Publisher != null) hashCode = hashCode * 59 + this.Publisher.GetHashCode();
                if (this.IconUrl != null) hashCode = hashCode * 59 + this.IconUrl.GetHashCode();
                if (this.Publishable != null) hashCode = hashCode * 59 + this.Publishable.GetHashCode();
                if (this.SandboxEnable != null) hashCode = hashCode * 59 + this.SandboxEnable.GetHashCode();
                return hashCode;
            }
        }
    }
}
