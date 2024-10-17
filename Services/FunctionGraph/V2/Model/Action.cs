using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// 节点操作详情
    /// </summary>
    public class Action 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("function_ref", NullValueHandling = NullValueHandling.Ignore)]
        public FunctionRef FunctionRef { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Action {\n");
            sb.Append("  functionRef: ").Append(FunctionRef).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Action);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Action input)
        {
            if (input == null) return false;
            if (this.FunctionRef != input.FunctionRef || (this.FunctionRef != null && !this.FunctionRef.Equals(input.FunctionRef))) return false;

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
                if (this.FunctionRef != null) hashCode = hashCode * 59 + this.FunctionRef.GetHashCode();
                return hashCode;
            }
        }
    }
}
