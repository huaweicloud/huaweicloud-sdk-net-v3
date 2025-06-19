using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 结果
    /// </summary>
    public class ListBriefRecordResponseBodyResult 
    {

        /// <summary>
        /// 需要查询的项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 简要构建信息列表
        /// </summary>
        [JsonProperty("brief_build_record_dtos", NullValueHandling = NullValueHandling.Ignore)]
        public List<BriefRecordItems> BriefBuildRecordDtos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListBriefRecordResponseBodyResult {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  briefBuildRecordDtos: ").Append(BriefBuildRecordDtos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListBriefRecordResponseBodyResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListBriefRecordResponseBodyResult input)
        {
            if (input == null) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.BriefBuildRecordDtos != input.BriefBuildRecordDtos || (this.BriefBuildRecordDtos != null && input.BriefBuildRecordDtos != null && !this.BriefBuildRecordDtos.SequenceEqual(input.BriefBuildRecordDtos))) return false;

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
                if (this.BriefBuildRecordDtos != null) hashCode = hashCode * 59 + this.BriefBuildRecordDtos.GetHashCode();
                return hashCode;
            }
        }
    }
}
