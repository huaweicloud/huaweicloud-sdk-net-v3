using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowRepoLastStatisticsResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("event", NullValueHandling = NullValueHandling.Ignore)]
        public StatisticEventsDto Event { get; set; }

        /// <summary>
        /// **参数解释：** 统计信息数量 **取值范围：** 最小0 **默认取值：** 0
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 统计信息
        /// </summary>
        [JsonProperty("statistics", NullValueHandling = NullValueHandling.Ignore)]
        public List<StatisticDto> Statistics { get; set; }

        /// <summary>
        /// 仓库近15日每日代码提交增减行数信息。
        /// </summary>
        [JsonProperty("codelines", NullValueHandling = NullValueHandling.Ignore)]
        public List<CodelineDto> Codelines { get; set; }

        /// <summary>
        /// **参数解释：** 分支提交总数。 **取值范围：** 最小0 **默认取值：** 0
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// **参数解释：** 仓库提交总数。 **取值范围：** 最小0 **默认取值：** 0
        /// </summary>
        [JsonProperty("all_branch_commits_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? AllBranchCommitsCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRepoLastStatisticsResponse {\n");
            sb.Append("  Event: ").Append(Event).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  statistics: ").Append(Statistics).Append("\n");
            sb.Append("  codelines: ").Append(Codelines).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  allBranchCommitsCount: ").Append(AllBranchCommitsCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRepoLastStatisticsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRepoLastStatisticsResponse input)
        {
            if (input == null) return false;
            if (this.Event != input.Event || (this.Event != null && !this.Event.Equals(input.Event))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.Statistics != input.Statistics || (this.Statistics != null && input.Statistics != null && !this.Statistics.SequenceEqual(input.Statistics))) return false;
            if (this.Codelines != input.Codelines || (this.Codelines != null && input.Codelines != null && !this.Codelines.SequenceEqual(input.Codelines))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.AllBranchCommitsCount != input.AllBranchCommitsCount || (this.AllBranchCommitsCount != null && !this.AllBranchCommitsCount.Equals(input.AllBranchCommitsCount))) return false;

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
                if (this.Event != null) hashCode = hashCode * 59 + this.Event.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Statistics != null) hashCode = hashCode * 59 + this.Statistics.GetHashCode();
                if (this.Codelines != null) hashCode = hashCode * 59 + this.Codelines.GetHashCode();
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.AllBranchCommitsCount != null) hashCode = hashCode * 59 + this.AllBranchCommitsCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
