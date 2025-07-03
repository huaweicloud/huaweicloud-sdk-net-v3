using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 数据库检查结果
    /// </summary>
    public class DBCheckDetail 
    {

        /// <summary>
        /// 检查说明链接
        /// </summary>
        [JsonProperty("documentation_link", NullValueHandling = NullValueHandling.Ignore)]
        public string DocumentationLink { get; set; }

        /// <summary>
        /// 检查项描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 检查项id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 检查项标题
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 检查状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 各项检查项检测到的问题
        /// </summary>
        [JsonProperty("detected_problems", NullValueHandling = NullValueHandling.Ignore)]
        public List<DetectedProblem> DetectedProblems { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DBCheckDetail {\n");
            sb.Append("  documentationLink: ").Append(DocumentationLink).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  detectedProblems: ").Append(DetectedProblems).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DBCheckDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DBCheckDetail input)
        {
            if (input == null) return false;
            if (this.DocumentationLink != input.DocumentationLink || (this.DocumentationLink != null && !this.DocumentationLink.Equals(input.DocumentationLink))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.DetectedProblems != input.DetectedProblems || (this.DetectedProblems != null && input.DetectedProblems != null && !this.DetectedProblems.SequenceEqual(input.DetectedProblems))) return false;

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
                if (this.DocumentationLink != null) hashCode = hashCode * 59 + this.DocumentationLink.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.DetectedProblems != null) hashCode = hashCode * 59 + this.DetectedProblems.GetHashCode();
                return hashCode;
            }
        }
    }
}
