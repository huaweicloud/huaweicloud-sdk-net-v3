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
    public class SearchByChecksumRequest 
    {

        /// <summary>
        /// checksum
        /// </summary>
        [SDKProperty("checksum", IsQuery = true)]
        [JsonProperty("checksum", NullValueHandling = NullValueHandling.Ignore)]
        public string Checksum { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [SDKProperty("page_no", IsQuery = true)]
        [JsonProperty("page_no", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageNo { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [SDKProperty("page_size", IsQuery = true)]
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 仓库类型
        /// </summary>
        [SDKProperty("format", IsQuery = true)]
        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public string Format { get; set; }

        /// <summary>
        /// 是否在项目中
        /// </summary>
        [SDKProperty("in_project", IsQuery = true)]
        [JsonProperty("in_project", NullValueHandling = NullValueHandling.Ignore)]
        public string InProject { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [SDKProperty("project_id", IsQuery = true)]
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchByChecksumRequest {\n");
            sb.Append("  checksum: ").Append(Checksum).Append("\n");
            sb.Append("  pageNo: ").Append(PageNo).Append("\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("  format: ").Append(Format).Append("\n");
            sb.Append("  inProject: ").Append(InProject).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchByChecksumRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchByChecksumRequest input)
        {
            if (input == null) return false;
            if (this.Checksum != input.Checksum || (this.Checksum != null && !this.Checksum.Equals(input.Checksum))) return false;
            if (this.PageNo != input.PageNo || (this.PageNo != null && !this.PageNo.Equals(input.PageNo))) return false;
            if (this.PageSize != input.PageSize || (this.PageSize != null && !this.PageSize.Equals(input.PageSize))) return false;
            if (this.Format != input.Format || (this.Format != null && !this.Format.Equals(input.Format))) return false;
            if (this.InProject != input.InProject || (this.InProject != null && !this.InProject.Equals(input.InProject))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;

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
                if (this.Checksum != null) hashCode = hashCode * 59 + this.Checksum.GetHashCode();
                if (this.PageNo != null) hashCode = hashCode * 59 + this.PageNo.GetHashCode();
                if (this.PageSize != null) hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.Format != null) hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.InProject != null) hashCode = hashCode * 59 + this.InProject.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
