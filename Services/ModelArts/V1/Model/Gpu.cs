using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// gpu规格信息。
    /// </summary>
    public class Gpu 
    {

        /// <summary>
        /// gpu卡数。
        /// </summary>
        [JsonProperty("unit_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? UnitNum { get; set; }

        /// <summary>
        /// 产品名。
        /// </summary>
        [JsonProperty("product_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductName { get; set; }

        /// <summary>
        /// 内存。
        /// </summary>
        [JsonProperty("memory", NullValueHandling = NullValueHandling.Ignore)]
        public string Memory { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Gpu {\n");
            sb.Append("  unitNum: ").Append(UnitNum).Append("\n");
            sb.Append("  productName: ").Append(ProductName).Append("\n");
            sb.Append("  memory: ").Append(Memory).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Gpu);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Gpu input)
        {
            if (input == null) return false;
            if (this.UnitNum != input.UnitNum || (this.UnitNum != null && !this.UnitNum.Equals(input.UnitNum))) return false;
            if (this.ProductName != input.ProductName || (this.ProductName != null && !this.ProductName.Equals(input.ProductName))) return false;
            if (this.Memory != input.Memory || (this.Memory != null && !this.Memory.Equals(input.Memory))) return false;

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
                if (this.UnitNum != null) hashCode = hashCode * 59 + this.UnitNum.GetHashCode();
                if (this.ProductName != null) hashCode = hashCode * 59 + this.ProductName.GetHashCode();
                if (this.Memory != null) hashCode = hashCode * 59 + this.Memory.GetHashCode();
                return hashCode;
            }
        }
    }
}
