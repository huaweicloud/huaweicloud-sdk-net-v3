using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// 获取组件环境拓扑数据的请求参数。
    /// </summary>
    public class EnvTopoRequest 
    {

        /// <summary>
        /// 环境id。
        /// </summary>
        [JsonProperty("target_env_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? TargetEnvId { get; set; }

        /// <summary>
        /// 方向，可为空。
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public string Direction { get; set; }

        /// <summary>
        /// 结束时间。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 开始时间。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 过滤。
        /// </summary>
        [JsonProperty("filter_user", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FilterUser { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnvTopoRequest {\n");
            sb.Append("  targetEnvId: ").Append(TargetEnvId).Append("\n");
            sb.Append("  direction: ").Append(Direction).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  filterUser: ").Append(FilterUser).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnvTopoRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EnvTopoRequest input)
        {
            if (input == null) return false;
            if (this.TargetEnvId != input.TargetEnvId || (this.TargetEnvId != null && !this.TargetEnvId.Equals(input.TargetEnvId))) return false;
            if (this.Direction != input.Direction || (this.Direction != null && !this.Direction.Equals(input.Direction))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.FilterUser != input.FilterUser || (this.FilterUser != null && !this.FilterUser.Equals(input.FilterUser))) return false;

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
                if (this.TargetEnvId != null) hashCode = hashCode * 59 + this.TargetEnvId.GetHashCode();
                if (this.Direction != null) hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.FilterUser != null) hashCode = hashCode * 59 + this.FilterUser.GetHashCode();
                return hashCode;
            }
        }
    }
}
