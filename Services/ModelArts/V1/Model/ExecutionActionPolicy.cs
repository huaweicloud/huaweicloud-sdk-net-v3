using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 执行动作策略。
    /// </summary>
    public class ExecutionActionPolicy 
    {

        /// <summary>
        /// 重跑的节点。
        /// </summary>
        [JsonProperty("rerun_steps", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RerunSteps { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecutionActionPolicy {\n");
            sb.Append("  rerunSteps: ").Append(RerunSteps).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExecutionActionPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExecutionActionPolicy input)
        {
            if (input == null) return false;
            if (this.RerunSteps != input.RerunSteps || (this.RerunSteps != null && input.RerunSteps != null && !this.RerunSteps.SequenceEqual(input.RerunSteps))) return false;

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
                if (this.RerunSteps != null) hashCode = hashCode * 59 + this.RerunSteps.GetHashCode();
                return hashCode;
            }
        }
    }
}
