using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ram.V1.Model
{
    /// <summary>
    /// The request body of AssociateResourceShare and DisassociateResourceShare operations.
    /// </summary>
    public class ResourceShareAssociationReqBody 
    {

        /// <summary>
        /// 指定与资源共享实例关联的一个或多个资源使用者的列表。
        /// </summary>
        [JsonProperty("principals", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Principals { get; set; }

        /// <summary>
        /// 指定与资源共享实例关联的一个或多个共享资源URN的列表。
        /// </summary>
        [JsonProperty("resource_urns", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ResourceUrns { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceShareAssociationReqBody {\n");
            sb.Append("  principals: ").Append(Principals).Append("\n");
            sb.Append("  resourceUrns: ").Append(ResourceUrns).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceShareAssociationReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceShareAssociationReqBody input)
        {
            if (input == null) return false;
            if (this.Principals != input.Principals || (this.Principals != null && input.Principals != null && !this.Principals.SequenceEqual(input.Principals))) return false;
            if (this.ResourceUrns != input.ResourceUrns || (this.ResourceUrns != null && input.ResourceUrns != null && !this.ResourceUrns.SequenceEqual(input.ResourceUrns))) return false;

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
                if (this.Principals != null) hashCode = hashCode * 59 + this.Principals.GetHashCode();
                if (this.ResourceUrns != null) hashCode = hashCode * 59 + this.ResourceUrns.GetHashCode();
                return hashCode;
            }
        }
    }
}
