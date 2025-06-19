using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 实际的数据类型：单个对象，集合 或 NULL
    /// </summary>
    public class QueryTaskTestCasesVo 
    {

        /// <summary>
        /// 关联的用例uris
        /// </summary>
        [JsonProperty("related_case_uris", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RelatedCaseUris { get; set; }

        /// <summary>
        /// 未关联的用例uris
        /// </summary>
        [JsonProperty("not_related_case_uris", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NotRelatedCaseUris { get; set; }

        /// <summary>
        /// 用例及任务信息
        /// </summary>
        [JsonProperty("case_task_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<RelateTaskTestCasesVo> CaseTaskInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryTaskTestCasesVo {\n");
            sb.Append("  relatedCaseUris: ").Append(RelatedCaseUris).Append("\n");
            sb.Append("  notRelatedCaseUris: ").Append(NotRelatedCaseUris).Append("\n");
            sb.Append("  caseTaskInfo: ").Append(CaseTaskInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryTaskTestCasesVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryTaskTestCasesVo input)
        {
            if (input == null) return false;
            if (this.RelatedCaseUris != input.RelatedCaseUris || (this.RelatedCaseUris != null && input.RelatedCaseUris != null && !this.RelatedCaseUris.SequenceEqual(input.RelatedCaseUris))) return false;
            if (this.NotRelatedCaseUris != input.NotRelatedCaseUris || (this.NotRelatedCaseUris != null && input.NotRelatedCaseUris != null && !this.NotRelatedCaseUris.SequenceEqual(input.NotRelatedCaseUris))) return false;
            if (this.CaseTaskInfo != input.CaseTaskInfo || (this.CaseTaskInfo != null && input.CaseTaskInfo != null && !this.CaseTaskInfo.SequenceEqual(input.CaseTaskInfo))) return false;

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
                if (this.RelatedCaseUris != null) hashCode = hashCode * 59 + this.RelatedCaseUris.GetHashCode();
                if (this.NotRelatedCaseUris != null) hashCode = hashCode * 59 + this.NotRelatedCaseUris.GetHashCode();
                if (this.CaseTaskInfo != null) hashCode = hashCode * 59 + this.CaseTaskInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
