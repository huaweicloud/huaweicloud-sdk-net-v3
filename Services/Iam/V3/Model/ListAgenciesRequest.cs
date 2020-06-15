using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListAgenciesRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("trust_domain_id", IsQuery = true)]
        public string TrustDomainId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        public string Name { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAgenciesRequest {\n");
            sb.Append("  trustDomainId: ").Append(TrustDomainId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAgenciesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAgenciesRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TrustDomainId == input.TrustDomainId ||
                    (this.TrustDomainId != null &&
                    this.TrustDomainId.Equals(input.TrustDomainId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.TrustDomainId != null)
                    hashCode = hashCode * 59 + this.TrustDomainId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }
    }
}
