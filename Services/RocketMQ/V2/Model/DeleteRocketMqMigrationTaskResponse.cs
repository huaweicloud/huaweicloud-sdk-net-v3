using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.RocketMQ.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class DeleteRocketMqMigrationTaskResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 删除成功的任务列表。 **约束限制**： 不涉及。 **取值范围**： 不涉及 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("success_task_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SuccessTaskList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteRocketMqMigrationTaskResponse {\n");
            sb.Append("  successTaskList: ").Append(SuccessTaskList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteRocketMqMigrationTaskResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteRocketMqMigrationTaskResponse input)
        {
            if (input == null) return false;
            if (this.SuccessTaskList != input.SuccessTaskList || (this.SuccessTaskList != null && input.SuccessTaskList != null && !this.SuccessTaskList.SequenceEqual(input.SuccessTaskList))) return false;

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
                if (this.SuccessTaskList != null) hashCode = hashCode * 59 + this.SuccessTaskList.GetHashCode();
                return hashCode;
            }
        }
    }
}
