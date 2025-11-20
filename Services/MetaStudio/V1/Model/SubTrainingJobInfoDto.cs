using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 子任务信息
    /// </summary>
    public class SubTrainingJobInfoDto 
    {

        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 子任务类型
        /// </summary>
        [JsonProperty("sub_job_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SubJobType { get; set; }

        /// <summary>
        /// 子任务心跳id
        /// </summary>
        [JsonProperty("heart_beat_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HeartBeatId { get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        [JsonProperty("last_update_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastUpdateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubTrainingJobInfoDto {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  subJobType: ").Append(SubJobType).Append("\n");
            sb.Append("  heartBeatId: ").Append(HeartBeatId).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  lastUpdateTime: ").Append(LastUpdateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubTrainingJobInfoDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SubTrainingJobInfoDto input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.SubJobType != input.SubJobType || (this.SubJobType != null && !this.SubJobType.Equals(input.SubJobType))) return false;
            if (this.HeartBeatId != input.HeartBeatId || (this.HeartBeatId != null && !this.HeartBeatId.Equals(input.HeartBeatId))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.LastUpdateTime != input.LastUpdateTime || (this.LastUpdateTime != null && !this.LastUpdateTime.Equals(input.LastUpdateTime))) return false;

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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.SubJobType != null) hashCode = hashCode * 59 + this.SubJobType.GetHashCode();
                if (this.HeartBeatId != null) hashCode = hashCode * 59 + this.HeartBeatId.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.LastUpdateTime != null) hashCode = hashCode * 59 + this.LastUpdateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
