using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class QueryRunRequestBody 
    {

        /// <summary>
        /// ResourceQL 表达式
        /// </summary>
        [JsonProperty("expression", NullValueHandling = NullValueHandling.Ignore)]
        public string Expression { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryRunRequestBody {\n");
            sb.Append("  expression: ").Append(Expression).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryRunRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryRunRequestBody input)
        {
            if (input == null) return false;
            if (this.Expression != input.Expression || (this.Expression != null && !this.Expression.Equals(input.Expression))) return false;

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
                if (this.Expression != null) hashCode = hashCode * 59 + this.Expression.GetHashCode();
                return hashCode;
            }
        }
    }
}
