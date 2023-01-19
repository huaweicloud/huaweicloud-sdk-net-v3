using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class IterationHistory 
    {

        /// <summary>
        /// 迭代ID
        /// </summary>
        [JsonProperty("iteration_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IterationId { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("operator", NullValueHandling = NullValueHandling.Ignore)]
        public IterationHistoryOperator Operator { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        [JsonProperty("operate", NullValueHandling = NullValueHandling.Ignore)]
        public string Operate { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        [JsonProperty("operate_time", NullValueHandling = NullValueHandling.Ignore)]
        public string OperateTime { get; set; }

        /// <summary>
        /// 操作详情
        /// </summary>
        [JsonProperty("details", NullValueHandling = NullValueHandling.Ignore)]
        public List<IterationHistoryDetails> Details { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IterationHistory {\n");
            sb.Append("  iterationId: ").Append(IterationId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  operate: ").Append(Operate).Append("\n");
            sb.Append("  operateTime: ").Append(OperateTime).Append("\n");
            sb.Append("  details: ").Append(Details).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IterationHistory);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IterationHistory input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IterationId == input.IterationId ||
                    (this.IterationId != null &&
                    this.IterationId.Equals(input.IterationId))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.Operator == input.Operator ||
                    (this.Operator != null &&
                    this.Operator.Equals(input.Operator))
                ) && 
                (
                    this.Operate == input.Operate ||
                    (this.Operate != null &&
                    this.Operate.Equals(input.Operate))
                ) && 
                (
                    this.OperateTime == input.OperateTime ||
                    (this.OperateTime != null &&
                    this.OperateTime.Equals(input.OperateTime))
                ) && 
                (
                    this.Details == input.Details ||
                    this.Details != null &&
                    input.Details != null &&
                    this.Details.SequenceEqual(input.Details)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.IterationId != null)
                    hashCode = hashCode * 59 + this.IterationId.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Operator != null)
                    hashCode = hashCode * 59 + this.Operator.GetHashCode();
                if (this.Operate != null)
                    hashCode = hashCode * 59 + this.Operate.GetHashCode();
                if (this.OperateTime != null)
                    hashCode = hashCode * 59 + this.OperateTime.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                return hashCode;
            }
        }
    }
}
