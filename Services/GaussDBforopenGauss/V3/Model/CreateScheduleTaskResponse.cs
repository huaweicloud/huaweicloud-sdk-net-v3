using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateScheduleTaskResponse : SdkResponse
    {

        /// <summary>
        /// 任务ID。
        /// </summary>
        [JsonProperty("instance_tasks", NullValueHandling = NullValueHandling.Ignore)]
        public List<InstanceTaskDetail> InstanceTasks { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateScheduleTaskResponse {\n");
            sb.Append("  instanceTasks: ").Append(InstanceTasks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateScheduleTaskResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateScheduleTaskResponse input)
        {
            if (input == null) return false;
            if (this.InstanceTasks != input.InstanceTasks || (this.InstanceTasks != null && input.InstanceTasks != null && !this.InstanceTasks.SequenceEqual(input.InstanceTasks))) return false;

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
                if (this.InstanceTasks != null) hashCode = hashCode * 59 + this.InstanceTasks.GetHashCode();
                return hashCode;
            }
        }
    }
}
