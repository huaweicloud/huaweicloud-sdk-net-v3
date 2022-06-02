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
    /// 自定义字段
    /// </summary>
    public class IssueCustomField 
    {

        /// <summary>
        /// 自定义字段
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 自定义字段
        /// </summary>
        [JsonProperty("custom_field", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField { get; set; }

        /// <summary>
        /// 自定义字段的可选值，多个值以英文逗号区分
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public string Options { get; set; }

        /// <summary>
        /// 自定义字段类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 自定义字段支持的工作项类型 2任务/Task,3缺陷/Bug,5Epic,6Feature,7Story
        /// </summary>
        [JsonProperty("tracker_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> TrackerIds { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssueCustomField {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  customField: ").Append(CustomField).Append("\n");
            sb.Append("  options: ").Append(Options).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  trackerIds: ").Append(TrackerIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IssueCustomField);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IssueCustomField input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.CustomField == input.CustomField ||
                    (this.CustomField != null &&
                    this.CustomField.Equals(input.CustomField))
                ) && 
                (
                    this.Options == input.Options ||
                    (this.Options != null &&
                    this.Options.Equals(input.Options))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.TrackerIds == input.TrackerIds ||
                    this.TrackerIds != null &&
                    input.TrackerIds != null &&
                    this.TrackerIds.SequenceEqual(input.TrackerIds)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.CustomField != null)
                    hashCode = hashCode * 59 + this.CustomField.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.TrackerIds != null)
                    hashCode = hashCode * 59 + this.TrackerIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
