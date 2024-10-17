using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowInternalVpcIgwRequest 
    {

        /// <summary>
        /// 形式为\\\&quot;fields&#x3D;id&amp;fields&#x3D;project_id&amp;...\\\&quot;，支持字段：id/project_id/vpc_id/created_at/updated_at/igw_cluster
        /// </summary>
        [SDKProperty("fields", IsQuery = true)]
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Fields { get; set; }

        /// <summary>
        /// 虚拟igw的uuid
        /// </summary>
        [SDKProperty("vpc_igw_id", IsPath = true)]
        [JsonProperty("vpc_igw_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcIgwId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowInternalVpcIgwRequest {\n");
            sb.Append("  fields: ").Append(Fields).Append("\n");
            sb.Append("  vpcIgwId: ").Append(VpcIgwId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowInternalVpcIgwRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowInternalVpcIgwRequest input)
        {
            if (input == null) return false;
            if (this.Fields != input.Fields || (this.Fields != null && input.Fields != null && !this.Fields.SequenceEqual(input.Fields))) return false;
            if (this.VpcIgwId != input.VpcIgwId || (this.VpcIgwId != null && !this.VpcIgwId.Equals(input.VpcIgwId))) return false;

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
                if (this.Fields != null) hashCode = hashCode * 59 + this.Fields.GetHashCode();
                if (this.VpcIgwId != null) hashCode = hashCode * 59 + this.VpcIgwId.GetHashCode();
                return hashCode;
            }
        }
    }
}
