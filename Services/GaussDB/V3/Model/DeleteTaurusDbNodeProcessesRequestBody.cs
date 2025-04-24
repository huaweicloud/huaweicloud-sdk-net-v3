using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 终止TaurusDB节点用户会话线程请求
    /// </summary>
    public class DeleteTaurusDbNodeProcessesRequestBody 
    {

        /// <summary>
        /// **参数解释**：  待终止用户会话线程ID列表。  通过查询节点用户会话线程接口，或show processlist命令获取。
        /// </summary>
        [JsonProperty("processes", NullValueHandling = NullValueHandling.Ignore)]
        public List<long?> Processes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteTaurusDbNodeProcessesRequestBody {\n");
            sb.Append("  processes: ").Append(Processes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteTaurusDbNodeProcessesRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteTaurusDbNodeProcessesRequestBody input)
        {
            if (input == null) return false;
            if (this.Processes != input.Processes || (this.Processes != null && input.Processes != null && !this.Processes.SequenceEqual(input.Processes))) return false;

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
                if (this.Processes != null) hashCode = hashCode * 59 + this.Processes.GetHashCode();
                return hashCode;
            }
        }
    }
}
