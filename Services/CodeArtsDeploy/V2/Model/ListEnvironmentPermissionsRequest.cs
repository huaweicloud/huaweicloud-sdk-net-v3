using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsDeploy.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListEnvironmentPermissionsRequest 
    {

        /// <summary>
        /// 应用id
        /// </summary>
        [SDKProperty("application_id", IsPath = true)]
        [JsonProperty("application_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// 环境id
        /// </summary>
        [SDKProperty("environment_id", IsPath = true)]
        [JsonProperty("environment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnvironmentId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEnvironmentPermissionsRequest {\n");
            sb.Append("  applicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  environmentId: ").Append(EnvironmentId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEnvironmentPermissionsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEnvironmentPermissionsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
                ) && 
                (
                    this.EnvironmentId == input.EnvironmentId ||
                    (this.EnvironmentId != null &&
                    this.EnvironmentId.Equals(input.EnvironmentId))
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
                if (this.ApplicationId != null)
                    hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                if (this.EnvironmentId != null)
                    hashCode = hashCode * 59 + this.EnvironmentId.GetHashCode();
                return hashCode;
            }
        }
    }
}
