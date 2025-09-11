using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SortInfo 
    {

        /// <summary>
        /// 是否升序
        /// </summary>
        [JsonProperty("asc", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Asc { get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public string Field { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SortInfo {\n");
            sb.Append("  asc: ").Append(Asc).Append("\n");
            sb.Append("  field: ").Append(Field).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SortInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SortInfo input)
        {
            if (input == null) return false;
            if (this.Asc != input.Asc || (this.Asc != null && !this.Asc.Equals(input.Asc))) return false;
            if (this.Field != input.Field || (this.Field != null && !this.Field.Equals(input.Field))) return false;

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
                if (this.Asc != null) hashCode = hashCode * 59 + this.Asc.GetHashCode();
                if (this.Field != null) hashCode = hashCode * 59 + this.Field.GetHashCode();
                return hashCode;
            }
        }
    }
}
