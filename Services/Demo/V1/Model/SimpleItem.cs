using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Demo.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SimpleItem 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("string_item", NullValueHandling = NullValueHandling.Ignore)]
        public string StringItem { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("int_item", NullValueHandling = NullValueHandling.Ignore)]
        public int? IntItem { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bool_item", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BoolItem { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SimpleItem {\n");
            sb.Append("  stringItem: ").Append(StringItem).Append("\n");
            sb.Append("  intItem: ").Append(IntItem).Append("\n");
            sb.Append("  boolItem: ").Append(BoolItem).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SimpleItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SimpleItem input)
        {
            if (input == null) return false;
            if (this.StringItem != input.StringItem || (this.StringItem != null && !this.StringItem.Equals(input.StringItem))) return false;
            if (this.IntItem != input.IntItem || (this.IntItem != null && !this.IntItem.Equals(input.IntItem))) return false;
            if (this.BoolItem != input.BoolItem || (this.BoolItem != null && !this.BoolItem.Equals(input.BoolItem))) return false;

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
                if (this.StringItem != null) hashCode = hashCode * 59 + this.StringItem.GetHashCode();
                if (this.IntItem != null) hashCode = hashCode * 59 + this.IntItem.GetHashCode();
                if (this.BoolItem != null) hashCode = hashCode * 59 + this.BoolItem.GetHashCode();
                return hashCode;
            }
        }
    }
}
