using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsCheck.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class RunTaskResponse : SdkResponse
    {

        /// <summary>
        /// 执行id
        /// </summary>
        [JsonProperty("exec_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RunTaskResponse {\n");
            sb.Append("  execId: ").Append(ExecId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RunTaskResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RunTaskResponse input)
        {
            if (input == null) return false;
            if (this.ExecId != input.ExecId || (this.ExecId != null && !this.ExecId.Equals(input.ExecId))) return false;

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
                if (this.ExecId != null) hashCode = hashCode * 59 + this.ExecId.GetHashCode();
                return hashCode;
            }
        }
    }
}
