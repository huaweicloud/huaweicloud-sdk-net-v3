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
    public class QueryInfo 
    {

        /// <summary>
        /// ResourceQL 查询字段
        /// </summary>
        [JsonProperty("select_fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SelectFields { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryInfo {\n");
            sb.Append("  selectFields: ").Append(SelectFields).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryInfo input)
        {
            if (input == null) return false;
            if (this.SelectFields != input.SelectFields || (this.SelectFields != null && input.SelectFields != null && !this.SelectFields.SequenceEqual(input.SelectFields))) return false;

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
                if (this.SelectFields != null) hashCode = hashCode * 59 + this.SelectFields.GetHashCode();
                return hashCode;
            }
        }
    }
}
