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
    /// 
    /// </summary>
    public class DeploymentTaskLimit 
    {

        /// <summary>
        /// **参数解释：** 最大并发任务数 **约束限制：** 不填保留原有值。 **取值范围：** [1, 100]。 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("max_concurrent_task", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxConcurrentTask { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeploymentTaskLimit {\n");
            sb.Append("  maxConcurrentTask: ").Append(MaxConcurrentTask).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeploymentTaskLimit);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeploymentTaskLimit input)
        {
            if (input == null) return false;
            if (this.MaxConcurrentTask != input.MaxConcurrentTask || (this.MaxConcurrentTask != null && !this.MaxConcurrentTask.Equals(input.MaxConcurrentTask))) return false;

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
                if (this.MaxConcurrentTask != null) hashCode = hashCode * 59 + this.MaxConcurrentTask.GetHashCode();
                return hashCode;
            }
        }
    }
}
