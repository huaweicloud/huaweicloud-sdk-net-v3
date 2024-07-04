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
    /// Response Object
    /// </summary>
    public class ListFlavorsResizeResponse : SdkResponse
    {

        /// <summary>
        /// 规格组列表  normal：通用增强型。 normal2：通用增强Ⅱ型。 armFlavors：鲲鹏通用增强型。 dedicicateNormal（dedicatedNormalLocalssd）：x86独享型。 armLocalssd：鲲鹏通用型。 normalLocalssd：x86通用型。 general：通用型。 dedicated 对于PostgreSQL引擎：独享型
        /// </summary>
        [JsonProperty("flavor_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<ComputeFlavorGroup> FlavorGroups { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListFlavorsResizeResponse {\n");
            sb.Append("  flavorGroups: ").Append(FlavorGroups).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListFlavorsResizeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListFlavorsResizeResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FlavorGroups == input.FlavorGroups ||
                    this.FlavorGroups != null &&
                    input.FlavorGroups != null &&
                    this.FlavorGroups.SequenceEqual(input.FlavorGroups)
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
                if (this.FlavorGroups != null)
                    hashCode = hashCode * 59 + this.FlavorGroups.GetHashCode();
                return hashCode;
            }
        }
    }
}
