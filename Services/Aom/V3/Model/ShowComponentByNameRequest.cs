using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowComponentByNameRequest 
    {

        /// <summary>
        /// 应用id
        /// </summary>
        [SDKProperty("application_id", IsPath = true)]
        [JsonProperty("application_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// 组件名称
        /// </summary>
        [SDKProperty("component_name", IsPath = true)]
        [JsonProperty("component_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowComponentByNameRequest {\n");
            sb.Append("  applicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  componentName: ").Append(ComponentName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowComponentByNameRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowComponentByNameRequest input)
        {
            if (input == null) return false;
            if (this.ApplicationId != input.ApplicationId || (this.ApplicationId != null && !this.ApplicationId.Equals(input.ApplicationId))) return false;
            if (this.ComponentName != input.ComponentName || (this.ComponentName != null && !this.ComponentName.Equals(input.ComponentName))) return false;

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
                if (this.ApplicationId != null) hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                if (this.ComponentName != null) hashCode = hashCode * 59 + this.ComponentName.GetHashCode();
                return hashCode;
            }
        }
    }
}
