using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 删除迁移任务请求体
    /// </summary>
    public class DeleteMigrateTaskRequest 
    {

        /// <summary>
        /// 删除的迁移任务ID列表。
        /// </summary>
        [JsonProperty("task_id_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TaskIdList { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteMigrateTaskRequest {\n");
            sb.Append("  taskIdList: ").Append(TaskIdList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteMigrateTaskRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteMigrateTaskRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TaskIdList == input.TaskIdList ||
                    this.TaskIdList != null &&
                    input.TaskIdList != null &&
                    this.TaskIdList.SequenceEqual(input.TaskIdList)
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
                if (this.TaskIdList != null)
                    hashCode = hashCode * 59 + this.TaskIdList.GetHashCode();
                return hashCode;
            }
        }
    }
}
