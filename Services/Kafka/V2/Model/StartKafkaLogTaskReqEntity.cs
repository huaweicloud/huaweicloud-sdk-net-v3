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
    public class StartKafkaLogTaskReqEntity 
    {

        /// <summary>
        /// **参数解释**： 日志文件名。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("log_file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogFileName { get; set; }

        /// <summary>
        /// **参数解释**： 日志组名称。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("log_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupName { get; set; }

        /// <summary>
        /// **参数解释**： 日志流名称。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("log_stream_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogStreamName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartKafkaLogTaskReqEntity {\n");
            sb.Append("  logFileName: ").Append(LogFileName).Append("\n");
            sb.Append("  logGroupName: ").Append(LogGroupName).Append("\n");
            sb.Append("  logStreamName: ").Append(LogStreamName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StartKafkaLogTaskReqEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StartKafkaLogTaskReqEntity input)
        {
            if (input == null) return false;
            if (this.LogFileName != input.LogFileName || (this.LogFileName != null && !this.LogFileName.Equals(input.LogFileName))) return false;
            if (this.LogGroupName != input.LogGroupName || (this.LogGroupName != null && !this.LogGroupName.Equals(input.LogGroupName))) return false;
            if (this.LogStreamName != input.LogStreamName || (this.LogStreamName != null && !this.LogStreamName.Equals(input.LogStreamName))) return false;

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
                if (this.LogFileName != null) hashCode = hashCode * 59 + this.LogFileName.GetHashCode();
                if (this.LogGroupName != null) hashCode = hashCode * 59 + this.LogGroupName.GetHashCode();
                if (this.LogStreamName != null) hashCode = hashCode * 59 + this.LogStreamName.GetHashCode();
                return hashCode;
            }
        }
    }
}
