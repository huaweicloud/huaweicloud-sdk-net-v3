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
    /// 
    /// </summary>
    public class RepoStatisticsLaunch 
    {

        /// <summary>
        /// 仓库是否可以统计
        /// </summary>
        [JsonProperty("can_statistics", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanStatistics { get; set; }

        /// <summary>
        /// sidekiq任务的 id
        /// </summary>
        [JsonProperty("join_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JoinId { get; set; }

        /// <summary>
        /// 启动仓库统计返回的信息
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepoStatisticsLaunch {\n");
            sb.Append("  canStatistics: ").Append(CanStatistics).Append("\n");
            sb.Append("  joinId: ").Append(JoinId).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RepoStatisticsLaunch);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RepoStatisticsLaunch input)
        {
            if (input == null) return false;
            if (this.CanStatistics != input.CanStatistics || (this.CanStatistics != null && !this.CanStatistics.Equals(input.CanStatistics))) return false;
            if (this.JoinId != input.JoinId || (this.JoinId != null && !this.JoinId.Equals(input.JoinId))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;

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
                if (this.CanStatistics != null) hashCode = hashCode * 59 + this.CanStatistics.GetHashCode();
                if (this.JoinId != null) hashCode = hashCode * 59 + this.JoinId.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                return hashCode;
            }
        }
    }
}
