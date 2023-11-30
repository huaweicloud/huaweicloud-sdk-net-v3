using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// values.yaml中的数据，数据结构以具体的模板为准
    /// </summary>
    public class ChartValueValues 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("basic", NullValueHandling = NullValueHandling.Ignore)]
        public Object Basic { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChartValueValues {\n");
            sb.Append("  basic: ").Append(Basic).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChartValueValues);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChartValueValues input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Basic == input.Basic ||
                    (this.Basic != null &&
                    this.Basic.Equals(input.Basic))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Basic != null)
                    hashCode = hashCode * 59 + this.Basic.GetHashCode();
                return hashCode;
            }
        }
    }
}
