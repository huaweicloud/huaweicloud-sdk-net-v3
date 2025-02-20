using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class QueryDiagnosisResultDiagnosisResults 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("item", NullValueHandling = NullValueHandling.Ignore)]
        public QueryDiagnosisResultItem Item { get; set; }

        /// <summary>
        /// 诊断项状态。
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// 诊断结果。
        /// </summary>
        [JsonProperty("result_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<QueryDiagnosisResultResultList> ResultList { get; set; }

        /// <summary>
        /// 诊断建议。
        /// </summary>
        [JsonProperty("suggestion_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<QueryDiagnosisResultSuggestionList> SuggestionList { get; set; }

        /// <summary>
        /// 诊断项得分。
        /// </summary>
        [JsonProperty("score", NullValueHandling = NullValueHandling.Ignore)]
        public int? Score { get; set; }

        /// <summary>
        /// 完成时间。
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryDiagnosisResultDiagnosisResults {\n");
            sb.Append("  item: ").Append(Item).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  resultList: ").Append(ResultList).Append("\n");
            sb.Append("  suggestionList: ").Append(SuggestionList).Append("\n");
            sb.Append("  score: ").Append(Score).Append("\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryDiagnosisResultDiagnosisResults);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryDiagnosisResultDiagnosisResults input)
        {
            if (input == null) return false;
            if (this.Item != input.Item || (this.Item != null && !this.Item.Equals(input.Item))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.ResultList != input.ResultList || (this.ResultList != null && input.ResultList != null && !this.ResultList.SequenceEqual(input.ResultList))) return false;
            if (this.SuggestionList != input.SuggestionList || (this.SuggestionList != null && input.SuggestionList != null && !this.SuggestionList.SequenceEqual(input.SuggestionList))) return false;
            if (this.Score != input.Score || (this.Score != null && !this.Score.Equals(input.Score))) return false;
            if (this.Time != input.Time || (this.Time != null && !this.Time.Equals(input.Time))) return false;

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
                if (this.Item != null) hashCode = hashCode * 59 + this.Item.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.ResultList != null) hashCode = hashCode * 59 + this.ResultList.GetHashCode();
                if (this.SuggestionList != null) hashCode = hashCode * 59 + this.SuggestionList.GetHashCode();
                if (this.Score != null) hashCode = hashCode * 59 + this.Score.GetHashCode();
                if (this.Time != null) hashCode = hashCode * 59 + this.Time.GetHashCode();
                return hashCode;
            }
        }
    }
}
