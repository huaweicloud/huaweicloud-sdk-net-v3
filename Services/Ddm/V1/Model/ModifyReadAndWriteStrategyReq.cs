using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// This is a auto read_weight Body Object
    /// </summary>
    public class ModifyReadAndWriteStrategyReq 
    {

        /// <summary>
        /// 主数据库实例与只读数据库实例的读权重集合。
        /// </summary>
        [JsonProperty("read_weight", NullValueHandling = NullValueHandling.Ignore)]
        public Object ReadWeight { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyReadAndWriteStrategyReq {\n");
            sb.Append("  readWeight: ").Append(ReadWeight).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyReadAndWriteStrategyReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyReadAndWriteStrategyReq input)
        {
            if (input == null) return false;
            if (this.ReadWeight != input.ReadWeight || (this.ReadWeight != null && !this.ReadWeight.Equals(input.ReadWeight))) return false;

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
                if (this.ReadWeight != null) hashCode = hashCode * 59 + this.ReadWeight.GetHashCode();
                return hashCode;
            }
        }
    }
}
