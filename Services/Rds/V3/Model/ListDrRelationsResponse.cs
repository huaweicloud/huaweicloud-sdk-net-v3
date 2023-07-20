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
    public class ListDrRelationsResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("instance_dr_relations", NullValueHandling = NullValueHandling.Ignore)]
        public List<InstanceDrRelation> InstanceDrRelations { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDrRelationsResponse {\n");
            sb.Append("  instanceDrRelations: ").Append(InstanceDrRelations).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDrRelationsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDrRelationsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstanceDrRelations == input.InstanceDrRelations ||
                    this.InstanceDrRelations != null &&
                    input.InstanceDrRelations != null &&
                    this.InstanceDrRelations.SequenceEqual(input.InstanceDrRelations)
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
                if (this.InstanceDrRelations != null)
                    hashCode = hashCode * 59 + this.InstanceDrRelations.GetHashCode();
                return hashCode;
            }
        }
    }
}
