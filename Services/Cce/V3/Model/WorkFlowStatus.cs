using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class WorkFlowStatus 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("phase", NullValueHandling = NullValueHandling.Ignore)]
        public WorkFlowPhase? Phase { get; set; }

        /// <summary>
        /// 升级流程中的各个任务项的执行状态
        /// </summary>
        [JsonProperty("pointStatuses", NullValueHandling = NullValueHandling.Ignore)]
        public List<PointStatus> PointStatuses { get; set; }

        /// <summary>
        /// 表示该升级流程的任务执行线路
        /// </summary>
        [JsonProperty("lineStatuses", NullValueHandling = NullValueHandling.Ignore)]
        public List<LineStatus> LineStatuses { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkFlowStatus {\n");
            sb.Append("  phase: ").Append(Phase).Append("\n");
            sb.Append("  pointStatuses: ").Append(PointStatuses).Append("\n");
            sb.Append("  lineStatuses: ").Append(LineStatuses).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkFlowStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkFlowStatus input)
        {
            if (input == null) return false;
            if (this.Phase != input.Phase || (this.Phase != null && !this.Phase.Equals(input.Phase))) return false;
            if (this.PointStatuses != input.PointStatuses || (this.PointStatuses != null && input.PointStatuses != null && !this.PointStatuses.SequenceEqual(input.PointStatuses))) return false;
            if (this.LineStatuses != input.LineStatuses || (this.LineStatuses != null && input.LineStatuses != null && !this.LineStatuses.SequenceEqual(input.LineStatuses))) return false;

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
                if (this.Phase != null) hashCode = hashCode * 59 + this.Phase.GetHashCode();
                if (this.PointStatuses != null) hashCode = hashCode * 59 + this.PointStatuses.GetHashCode();
                if (this.LineStatuses != null) hashCode = hashCode * 59 + this.LineStatuses.GetHashCode();
                return hashCode;
            }
        }
    }
}
