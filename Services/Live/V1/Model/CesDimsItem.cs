using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// CES查询维度信息
    /// </summary>
    public class CesDimsItem 
    {

        /// <summary>
        /// 查询参数
        /// </summary>
        [JsonProperty("params", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Params { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("display", NullValueHandling = NullValueHandling.Ignore)]
        public CesDimsItemDisplay Display { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CesDimsItem {\n");
            sb.Append("  Params: ").Append(Params).Append("\n");
            sb.Append("  display: ").Append(Display).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CesDimsItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CesDimsItem input)
        {
            if (input == null) return false;
            if (this.Params != input.Params || (this.Params != null && input.Params != null && !this.Params.SequenceEqual(input.Params))) return false;
            if (this.Display != input.Display || (this.Display != null && !this.Display.Equals(input.Display))) return false;

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
                if (this.Params != null) hashCode = hashCode * 59 + this.Params.GetHashCode();
                if (this.Display != null) hashCode = hashCode * 59 + this.Display.GetHashCode();
                return hashCode;
            }
        }
    }
}
