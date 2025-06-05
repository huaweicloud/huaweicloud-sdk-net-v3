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
    /// 当前用户的项目信息列表
    /// </summary>
    public class ShowRelatedProjectResult 
    {

        /// <summary>
        /// 总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Total { get; set; }

        /// <summary>
        /// 项目信息列表
        /// </summary>
        [JsonProperty("project_info_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowRelatedProjectResultProjectInfoList> ProjectInfoList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRelatedProjectResult {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  projectInfoList: ").Append(ProjectInfoList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRelatedProjectResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRelatedProjectResult input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.ProjectInfoList != input.ProjectInfoList || (this.ProjectInfoList != null && input.ProjectInfoList != null && !this.ProjectInfoList.SequenceEqual(input.ProjectInfoList))) return false;

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
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.ProjectInfoList != null) hashCode = hashCode * 59 + this.ProjectInfoList.GetHashCode();
                return hashCode;
            }
        }
    }
}
