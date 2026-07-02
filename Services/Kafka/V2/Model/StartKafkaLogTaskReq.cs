using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class StartKafkaLogTaskReq 
    {

        /// <summary>
        /// **参数解释**： 日志任务列表。
        /// </summary>
        [JsonProperty("log_task_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<StartKafkaLogTaskReqEntity> LogTaskList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartKafkaLogTaskReq {\n");
            sb.Append("  logTaskList: ").Append(LogTaskList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StartKafkaLogTaskReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StartKafkaLogTaskReq input)
        {
            if (input == null) return false;
            if (this.LogTaskList != input.LogTaskList || (this.LogTaskList != null && input.LogTaskList != null && !this.LogTaskList.SequenceEqual(input.LogTaskList))) return false;

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
                if (this.LogTaskList != null) hashCode = hashCode * 59 + this.LogTaskList.GetHashCode();
                return hashCode;
            }
        }
    }
}
