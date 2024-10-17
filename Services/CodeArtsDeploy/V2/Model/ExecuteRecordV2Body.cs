using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsDeploy.V2.Model
{
    /// <summary>
    /// 应用部署记录Body
    /// </summary>
    public class ExecuteRecordV2Body 
    {

        /// <summary>
        /// 部署用时
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public string Duration { get; set; }

        /// <summary>
        /// 应用状态
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// 操作人用户名
        /// </summary>
        [JsonProperty("operator", NullValueHandling = NullValueHandling.Ignore)]
        public string Operator { get; set; }

        /// <summary>
        /// 部署记录id
        /// </summary>
        [JsonProperty("execution_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// 部署应用的开始时间
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 操作人昵称
        /// </summary>
        [JsonProperty("nickname", NullValueHandling = NullValueHandling.Ignore)]
        public string Nickname { get; set; }

        /// <summary>
        /// 部署应用的结束时间
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 部署记录序列号
        /// </summary>
        [JsonProperty("release_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? ReleaseId { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecuteRecordV2Body {\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  executionId: ").Append(ExecutionId).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  nickname: ").Append(Nickname).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  releaseId: ").Append(ReleaseId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExecuteRecordV2Body);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExecuteRecordV2Body input)
        {
            if (input == null) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.Operator != input.Operator || (this.Operator != null && !this.Operator.Equals(input.Operator))) return false;
            if (this.ExecutionId != input.ExecutionId || (this.ExecutionId != null && !this.ExecutionId.Equals(input.ExecutionId))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.Nickname != input.Nickname || (this.Nickname != null && !this.Nickname.Equals(input.Nickname))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.ReleaseId != input.ReleaseId || (this.ReleaseId != null && !this.ReleaseId.Equals(input.ReleaseId))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;

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
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Operator != null) hashCode = hashCode * 59 + this.Operator.GetHashCode();
                if (this.ExecutionId != null) hashCode = hashCode * 59 + this.ExecutionId.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.Nickname != null) hashCode = hashCode * 59 + this.Nickname.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.ReleaseId != null) hashCode = hashCode * 59 + this.ReleaseId.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
