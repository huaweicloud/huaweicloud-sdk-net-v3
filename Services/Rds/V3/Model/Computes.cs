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
    public class Computes 
    {

        /// <summary>
        /// 群组类型。  - X86：X86架构。 - ARM：ARM架构。
        /// </summary>
        [JsonProperty("group_type", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupType { get; set; }

        /// <summary>
        /// 计算规格信息。
        /// </summary>
        [JsonProperty("compute_flavors", NullValueHandling = NullValueHandling.Ignore)]
        public List<ScaleFlavors> ComputeFlavors { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Computes {\n");
            sb.Append("  groupType: ").Append(GroupType).Append("\n");
            sb.Append("  computeFlavors: ").Append(ComputeFlavors).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Computes);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Computes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupType == input.GroupType ||
                    (this.GroupType != null &&
                    this.GroupType.Equals(input.GroupType))
                ) && 
                (
                    this.ComputeFlavors == input.ComputeFlavors ||
                    this.ComputeFlavors != null &&
                    input.ComputeFlavors != null &&
                    this.ComputeFlavors.SequenceEqual(input.ComputeFlavors)
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
                if (this.GroupType != null)
                    hashCode = hashCode * 59 + this.GroupType.GetHashCode();
                if (this.ComputeFlavors != null)
                    hashCode = hashCode * 59 + this.ComputeFlavors.GetHashCode();
                return hashCode;
            }
        }
    }
}
