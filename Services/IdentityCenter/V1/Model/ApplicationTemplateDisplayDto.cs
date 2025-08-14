using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenter.V1.Model
{
    /// <summary>
    /// 应用程序模板显示信息
    /// </summary>
    public class ApplicationTemplateDisplayDto 
    {

        /// <summary>
        /// 应用程序Id,以app-为前缀
        /// </summary>
        [JsonProperty("application_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("display", NullValueHandling = NullValueHandling.Ignore)]
        public DisplayDto Display { get; set; }

        /// <summary>
        /// 应用程序类型
        /// </summary>
        [JsonProperty("application_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicationType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationTemplateDisplayDto {\n");
            sb.Append("  applicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  display: ").Append(Display).Append("\n");
            sb.Append("  applicationType: ").Append(ApplicationType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApplicationTemplateDisplayDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ApplicationTemplateDisplayDto input)
        {
            if (input == null) return false;
            if (this.ApplicationId != input.ApplicationId || (this.ApplicationId != null && !this.ApplicationId.Equals(input.ApplicationId))) return false;
            if (this.Display != input.Display || (this.Display != null && !this.Display.Equals(input.Display))) return false;
            if (this.ApplicationType != input.ApplicationType || (this.ApplicationType != null && !this.ApplicationType.Equals(input.ApplicationType))) return false;

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
                if (this.Display != null) hashCode = hashCode * 59 + this.Display.GetHashCode();
                if (this.ApplicationType != null) hashCode = hashCode * 59 + this.ApplicationType.GetHashCode();
                return hashCode;
            }
        }
    }
}
