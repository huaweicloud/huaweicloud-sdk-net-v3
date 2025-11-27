using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UCSTaskSpec 
    {

        /// <summary>
        /// 所属job的ID
        /// </summary>
        [JsonProperty("jobID", NullValueHandling = NullValueHandling.Ignore)]
        public string JobID { get; set; }

        /// <summary>
        /// 执行目标
        /// </summary>
        [JsonProperty("target", NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }

        /// <summary>
        /// 执行目标类型
        /// </summary>
        [JsonProperty("targetType", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetType { get; set; }

        /// <summary>
        /// Task执行等待时间，单位：秒
        /// </summary>
        [JsonProperty("waitTimeOut", NullValueHandling = NullValueHandling.Ignore)]
        public int? WaitTimeOut { get; set; }

        /// <summary>
        /// Task类别
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 执行方式：parallel和serial二选一
        /// </summary>
        [JsonProperty("runway", NullValueHandling = NullValueHandling.Ignore)]
        public string Runway { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UCSTaskSpec {\n");
            sb.Append("  jobID: ").Append(JobID).Append("\n");
            sb.Append("  target: ").Append(Target).Append("\n");
            sb.Append("  targetType: ").Append(TargetType).Append("\n");
            sb.Append("  waitTimeOut: ").Append(WaitTimeOut).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  runway: ").Append(Runway).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UCSTaskSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UCSTaskSpec input)
        {
            if (input == null) return false;
            if (this.JobID != input.JobID || (this.JobID != null && !this.JobID.Equals(input.JobID))) return false;
            if (this.Target != input.Target || (this.Target != null && !this.Target.Equals(input.Target))) return false;
            if (this.TargetType != input.TargetType || (this.TargetType != null && !this.TargetType.Equals(input.TargetType))) return false;
            if (this.WaitTimeOut != input.WaitTimeOut || (this.WaitTimeOut != null && !this.WaitTimeOut.Equals(input.WaitTimeOut))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Runway != input.Runway || (this.Runway != null && !this.Runway.Equals(input.Runway))) return false;

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
                if (this.JobID != null) hashCode = hashCode * 59 + this.JobID.GetHashCode();
                if (this.Target != null) hashCode = hashCode * 59 + this.Target.GetHashCode();
                if (this.TargetType != null) hashCode = hashCode * 59 + this.TargetType.GetHashCode();
                if (this.WaitTimeOut != null) hashCode = hashCode * 59 + this.WaitTimeOut.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Runway != null) hashCode = hashCode * 59 + this.Runway.GetHashCode();
                return hashCode;
            }
        }
    }
}
