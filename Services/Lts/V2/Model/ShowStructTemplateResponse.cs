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
            if (input == null)
                return false;

            return 
                (
                    this.DemoFields == input.DemoFields ||
                    this.DemoFields != null &&
                    input.DemoFields != null &&
                    this.DemoFields.SequenceEqual(input.DemoFields)
                ) && 
                (
                    this.TagFields == input.TagFields ||
                    this.TagFields != null &&
                    input.TagFields != null &&
                    this.TagFields.SequenceEqual(input.TagFields)
                ) && 
                (
                    this.DemoLog == input.DemoLog ||
                    (this.DemoLog != null &&
                    this.DemoLog.Equals(input.DemoLog))
                ) && 
                (
                    this.DemoLabel == input.DemoLabel ||
                    (this.DemoLabel != null &&
                    this.DemoLabel.Equals(input.DemoLabel))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LogGroupId == input.LogGroupId ||
                    (this.LogGroupId != null &&
                    this.LogGroupId.Equals(input.LogGroupId))
                ) && 
                (
                    this.Rule == input.Rule ||
                    (this.Rule != null &&
                    this.Rule.Equals(input.Rule))
                ) && 
                (
                    this.ClusterInfo == input.ClusterInfo ||
                    (this.ClusterInfo != null &&
                    this.ClusterInfo.Equals(input.ClusterInfo))
                ) && 
                (
                    this.LogStreamId == input.LogStreamId ||
                    (this.LogStreamId != null &&
                    this.LogStreamId.Equals(input.LogStreamId))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.TemplateName == input.TemplateName ||
                    (this.TemplateName != null &&
                    this.TemplateName.Equals(input.TemplateName))
                ) && 
                (
                    this.Regex == input.Regex ||
                    (this.Regex != null &&
                    this.Regex.Equals(input.Regex))
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
                if (this.DemoFields != null)
                    hashCode = hashCode * 59 + this.DemoFields.GetHashCode();
                if (this.TagFields != null)
                    hashCode = hashCode * 59 + this.TagFields.GetHashCode();
                if (this.DemoLog != null)
                    hashCode = hashCode * 59 + this.DemoLog.GetHashCode();
                if (this.DemoLabel != null)
                    hashCode = hashCode * 59 + this.DemoLabel.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LogGroupId != null)
                    hashCode = hashCode * 59 + this.LogGroupId.GetHashCode();
                if (this.Rule != null)
                    hashCode = hashCode * 59 + this.Rule.GetHashCode();
                if (this.ClusterInfo != null)
                    hashCode = hashCode * 59 + this.ClusterInfo.GetHashCode();
                if (this.LogStreamId != null)
                    hashCode = hashCode * 59 + this.LogStreamId.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.TemplateName != null)
                    hashCode = hashCode * 59 + this.TemplateName.GetHashCode();
                if (this.Regex != null)
                    hashCode = hashCode * 59 + this.Regex.GetHashCode();
                return hashCode;
            }
        }
    }
}
