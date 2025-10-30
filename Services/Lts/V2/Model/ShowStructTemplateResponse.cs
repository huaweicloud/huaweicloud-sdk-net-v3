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
    public class ShowStructTemplateResponse : SdkResponse
    {

        /// <summary>
        /// 结构化字段
        /// </summary>
        [JsonProperty("demoFields", NullValueHandling = NullValueHandling.Ignore)]
        public List<StructFieldInfoReturn> DemoFields { get; set; }

        /// <summary>
        /// 关键词详细信息
        /// </summary>
        [JsonProperty("tagFields", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagFieldsInfo> TagFields { get; set; }

        /// <summary>
        /// 示例日志
        /// </summary>
        [JsonProperty("demoLog", NullValueHandling = NullValueHandling.Ignore)]
        public string DemoLog { get; set; }

        /// <summary>
        /// 测试
        /// </summary>
        [JsonProperty("demoLabel", NullValueHandling = NullValueHandling.Ignore)]
        public string DemoLabel { get; set; }

        /// <summary>
        /// id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 日志组ID
        /// </summary>
        [JsonProperty("logGroupId", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rule", NullValueHandling = NullValueHandling.Ignore)]
        public ShowStructTemplateRule Rule { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cluster_info", NullValueHandling = NullValueHandling.Ignore)]
        public ShowStructTemplateclusterInfo ClusterInfo { get; set; }

        /// <summary>
        /// 日志流ID
        /// </summary>
        [JsonProperty("logStreamId", NullValueHandling = NullValueHandling.Ignore)]
        public string LogStreamId { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("projectId", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 测试
        /// </summary>
        [JsonProperty("templateName", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateName { get; set; }

        /// <summary>
        /// 为了兼容前台数据格式
        /// </summary>
        [JsonProperty("regex", NullValueHandling = NullValueHandling.Ignore)]
        public string Regex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_time_info", NullValueHandling = NullValueHandling.Ignore)]
        public CustomTimeInfo CustomTimeInfo { get; set; }

        /// <summary>
        /// **参数解释：** 是否上传原始日志。 **取值范围：** - true - fasle
        /// </summary>
        [JsonProperty("uploadOriginalLog", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UploadOriginalLog { get; set; }

        /// <summary>
        /// **参数解释：** 是否将解析失败的原始上传到指定系统字段日志。 **取值范围：** - true - fasle
        /// </summary>
        [JsonProperty("uploadParseFailedLog", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UploadParseFailedLog { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowStructTemplateResponse {\n");
            sb.Append("  demoFields: ").Append(DemoFields).Append("\n");
            sb.Append("  tagFields: ").Append(TagFields).Append("\n");
            sb.Append("  demoLog: ").Append(DemoLog).Append("\n");
            sb.Append("  demoLabel: ").Append(DemoLabel).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  logGroupId: ").Append(LogGroupId).Append("\n");
            sb.Append("  rule: ").Append(Rule).Append("\n");
            sb.Append("  clusterInfo: ").Append(ClusterInfo).Append("\n");
            sb.Append("  logStreamId: ").Append(LogStreamId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  templateName: ").Append(TemplateName).Append("\n");
            sb.Append("  regex: ").Append(Regex).Append("\n");
            sb.Append("  customTimeInfo: ").Append(CustomTimeInfo).Append("\n");
            sb.Append("  uploadOriginalLog: ").Append(UploadOriginalLog).Append("\n");
            sb.Append("  uploadParseFailedLog: ").Append(UploadParseFailedLog).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowStructTemplateResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowStructTemplateResponse input)
        {
            if (input == null) return false;
            if (this.DemoFields != input.DemoFields || (this.DemoFields != null && input.DemoFields != null && !this.DemoFields.SequenceEqual(input.DemoFields))) return false;
            if (this.TagFields != input.TagFields || (this.TagFields != null && input.TagFields != null && !this.TagFields.SequenceEqual(input.TagFields))) return false;
            if (this.DemoLog != input.DemoLog || (this.DemoLog != null && !this.DemoLog.Equals(input.DemoLog))) return false;
            if (this.DemoLabel != input.DemoLabel || (this.DemoLabel != null && !this.DemoLabel.Equals(input.DemoLabel))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.LogGroupId != input.LogGroupId || (this.LogGroupId != null && !this.LogGroupId.Equals(input.LogGroupId))) return false;
            if (this.Rule != input.Rule || (this.Rule != null && !this.Rule.Equals(input.Rule))) return false;
            if (this.ClusterInfo != input.ClusterInfo || (this.ClusterInfo != null && !this.ClusterInfo.Equals(input.ClusterInfo))) return false;
            if (this.LogStreamId != input.LogStreamId || (this.LogStreamId != null && !this.LogStreamId.Equals(input.LogStreamId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.TemplateName != input.TemplateName || (this.TemplateName != null && !this.TemplateName.Equals(input.TemplateName))) return false;
            if (this.Regex != input.Regex || (this.Regex != null && !this.Regex.Equals(input.Regex))) return false;
            if (this.CustomTimeInfo != input.CustomTimeInfo || (this.CustomTimeInfo != null && !this.CustomTimeInfo.Equals(input.CustomTimeInfo))) return false;
            if (this.UploadOriginalLog != input.UploadOriginalLog || (this.UploadOriginalLog != null && !this.UploadOriginalLog.Equals(input.UploadOriginalLog))) return false;
            if (this.UploadParseFailedLog != input.UploadParseFailedLog || (this.UploadParseFailedLog != null && !this.UploadParseFailedLog.Equals(input.UploadParseFailedLog))) return false;

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
                if (this.DemoFields != null) hashCode = hashCode * 59 + this.DemoFields.GetHashCode();
                if (this.TagFields != null) hashCode = hashCode * 59 + this.TagFields.GetHashCode();
                if (this.DemoLog != null) hashCode = hashCode * 59 + this.DemoLog.GetHashCode();
                if (this.DemoLabel != null) hashCode = hashCode * 59 + this.DemoLabel.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LogGroupId != null) hashCode = hashCode * 59 + this.LogGroupId.GetHashCode();
                if (this.Rule != null) hashCode = hashCode * 59 + this.Rule.GetHashCode();
                if (this.ClusterInfo != null) hashCode = hashCode * 59 + this.ClusterInfo.GetHashCode();
                if (this.LogStreamId != null) hashCode = hashCode * 59 + this.LogStreamId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.TemplateName != null) hashCode = hashCode * 59 + this.TemplateName.GetHashCode();
                if (this.Regex != null) hashCode = hashCode * 59 + this.Regex.GetHashCode();
                if (this.CustomTimeInfo != null) hashCode = hashCode * 59 + this.CustomTimeInfo.GetHashCode();
                if (this.UploadOriginalLog != null) hashCode = hashCode * 59 + this.UploadOriginalLog.GetHashCode();
                if (this.UploadParseFailedLog != null) hashCode = hashCode * 59 + this.UploadParseFailedLog.GetHashCode();
                return hashCode;
            }
        }
    }
}
