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
    /// Request Object
    /// </summary>
    public class ShowJobTotalRequest 
    {

        /// <summary>
        /// 构建工程项目ID，36位数字、小写字母组合。
        /// </summary>
        [SDKProperty("build_project_id", IsPath = true)]
        [JsonProperty("build_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildProjectId { get; set; }

        /// <summary>
        /// 区间开始时间，格式yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [SDKProperty("from_date", IsQuery = true)]
        [JsonProperty("from_date", NullValueHandling = NullValueHandling.Ignore)]
        public string FromDate { get; set; }

        /// <summary>
        /// 区间结束时间，格式yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [SDKProperty("to_date", IsQuery = true)]
        [JsonProperty("to_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ToDate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowJobTotalRequest {\n");
            sb.Append("  buildProjectId: ").Append(BuildProjectId).Append("\n");
            sb.Append("  fromDate: ").Append(FromDate).Append("\n");
            sb.Append("  toDate: ").Append(ToDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowJobTotalRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowJobTotalRequest input)
        {
            if (input == null) return false;
            if (this.BuildProjectId != input.BuildProjectId || (this.BuildProjectId != null && !this.BuildProjectId.Equals(input.BuildProjectId))) return false;
            if (this.FromDate != input.FromDate || (this.FromDate != null && !this.FromDate.Equals(input.FromDate))) return false;
            if (this.ToDate != input.ToDate || (this.ToDate != null && !this.ToDate.Equals(input.ToDate))) return false;

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
                if (this.BuildProjectId != null) hashCode = hashCode * 59 + this.BuildProjectId.GetHashCode();
                if (this.FromDate != null) hashCode = hashCode * 59 + this.FromDate.GetHashCode();
                if (this.ToDate != null) hashCode = hashCode * 59 + this.ToDate.GetHashCode();
                return hashCode;
            }
        }
    }
}
