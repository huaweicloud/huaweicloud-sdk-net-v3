using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ModifyCollationRequestBody 
    {

        /// <summary>
        /// 字符集。 取值范围：根据查询SQL Server可用字符集查询可设置的字符集。
        /// </summary>
        [JsonProperty("collation", NullValueHandling = NullValueHandling.Ignore)]
        public string Collation { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyCollationRequestBody {\n");
            sb.Append("  collation: ").Append(Collation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyCollationRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyCollationRequestBody input)
        {
            if (input == null) return false;
            if (this.Collation != input.Collation || (this.Collation != null && !this.Collation.Equals(input.Collation))) return false;

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
                if (this.Collation != null) hashCode = hashCode * 59 + this.Collation.GetHashCode();
                return hashCode;
            }
        }
    }
}
