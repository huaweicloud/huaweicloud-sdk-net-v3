using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 重试任务请求。
    /// </summary>
    public class JobActionsReq 
    {

        /// <summary>
        /// 操作类型。retry代表重试。
        /// </summary>
        [JsonProperty("op_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OpType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobActionsReq {\n");
            sb.Append("  opType: ").Append(OpType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobActionsReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobActionsReq input)
        {
            if (input == null) return false;
            if (this.OpType != input.OpType || (this.OpType != null && !this.OpType.Equals(input.OpType))) return false;

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
                if (this.OpType != null) hashCode = hashCode * 59 + this.OpType.GetHashCode();
                return hashCode;
            }
        }
    }
}
