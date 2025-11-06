using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowStatisticCommitRequest 
    {

        /// <summary>
        /// 仓库短id
        /// </summary>
        [SDKProperty("repository_id", IsPath = true)]
        [JsonProperty("repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepositoryId { get; set; }

        /// <summary>
        /// 分支名称
        /// </summary>
        [SDKProperty("ref_name", IsQuery = true)]
        [JsonProperty("ref_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RefName { get; set; }

        /// <summary>
        /// 起始提交日期,格式为yyyy-MM-dd
        /// </summary>
        [SDKProperty("begin_date", IsQuery = true)]
        [JsonProperty("begin_date", NullValueHandling = NullValueHandling.Ignore)]
        public string BeginDate { get; set; }

        /// <summary>
        /// 终止提交日期,格式为yyyy-MM-dd（begin_date和end_date时间间隔不超过60天）
        /// </summary>
        [SDKProperty("end_date", IsQuery = true)]
        [JsonProperty("end_date", NullValueHandling = NullValueHandling.Ignore)]
        public string EndDate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowStatisticCommitRequest {\n");
            sb.Append("  repositoryId: ").Append(RepositoryId).Append("\n");
            sb.Append("  refName: ").Append(RefName).Append("\n");
            sb.Append("  beginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  endDate: ").Append(EndDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowStatisticCommitRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowStatisticCommitRequest input)
        {
            if (input == null) return false;
            if (this.RepositoryId != input.RepositoryId || (this.RepositoryId != null && !this.RepositoryId.Equals(input.RepositoryId))) return false;
            if (this.RefName != input.RefName || (this.RefName != null && !this.RefName.Equals(input.RefName))) return false;
            if (this.BeginDate != input.BeginDate || (this.BeginDate != null && !this.BeginDate.Equals(input.BeginDate))) return false;
            if (this.EndDate != input.EndDate || (this.EndDate != null && !this.EndDate.Equals(input.EndDate))) return false;

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
                if (this.RepositoryId != null) hashCode = hashCode * 59 + this.RepositoryId.GetHashCode();
                if (this.RefName != null) hashCode = hashCode * 59 + this.RefName.GetHashCode();
                if (this.BeginDate != null) hashCode = hashCode * 59 + this.BeginDate.GetHashCode();
                if (this.EndDate != null) hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                return hashCode;
            }
        }
    }
}
