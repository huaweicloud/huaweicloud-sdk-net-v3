using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eps.v1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateEnterpriseProjectResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("enterprise_project", NullValueHandling = NullValueHandling.Ignore)]
        public EpDetail EnterpriseProject { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateEnterpriseProjectResponse {\n");
            sb.Append("  enterpriseProject: ").Append(EnterpriseProject).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateEnterpriseProjectResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateEnterpriseProjectResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnterpriseProject == input.EnterpriseProject ||
                    (this.EnterpriseProject != null &&
                    this.EnterpriseProject.Equals(input.EnterpriseProject))
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
                if (this.EnterpriseProject != null)
                    hashCode = hashCode * 59 + this.EnterpriseProject.GetHashCode();
                return hashCode;
            }
        }
    }
}
