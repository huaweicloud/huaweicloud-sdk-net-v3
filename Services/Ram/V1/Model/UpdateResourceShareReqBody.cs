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
    /// The request body of the UpdateResourceShare operation.
    /// </summary>
    public class UpdateResourceShareReqBody 
    {

        /// <summary>
        /// 资源共享实例的名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 资源共享实例的描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 资源共享实例是否支持共享给组织外账号。
        /// </summary>
        [JsonProperty("allow_external_principals", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowExternalPrincipals { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateResourceShareReqBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  allowExternalPrincipals: ").Append(AllowExternalPrincipals).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateResourceShareReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateResourceShareReqBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.AllowExternalPrincipals == input.AllowExternalPrincipals ||
                    (this.AllowExternalPrincipals != null &&
                    this.AllowExternalPrincipals.Equals(input.AllowExternalPrincipals))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.AllowExternalPrincipals != null)
                    hashCode = hashCode * 59 + this.AllowExternalPrincipals.GetHashCode();
                return hashCode;
            }
        }
    }
}
