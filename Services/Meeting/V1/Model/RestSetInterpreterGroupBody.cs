using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 设置传译组请求体
    /// </summary>
    public class RestSetInterpreterGroupBody 
    {

        /// <summary>
        /// 传译组列表信息
        /// </summary>
        [JsonProperty("interpreterGroups", NullValueHandling = NullValueHandling.Ignore)]
        public List<InterpreterGroupInfo> InterpreterGroups { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestSetInterpreterGroupBody {\n");
            sb.Append("  interpreterGroups: ").Append(InterpreterGroups).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestSetInterpreterGroupBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestSetInterpreterGroupBody input)
        {
            if (input == null) return false;
            if (this.InterpreterGroups != input.InterpreterGroups || (this.InterpreterGroups != null && input.InterpreterGroups != null && !this.InterpreterGroups.SequenceEqual(input.InterpreterGroups))) return false;

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
                if (this.InterpreterGroups != null) hashCode = hashCode * 59 + this.InterpreterGroups.GetHashCode();
                return hashCode;
            }
        }
    }
}
