using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListHourPackagesTypeRequest 
    {

        /// <summary>
        /// 小时包对应的按需桌面的资源规格编码。
        /// </summary>
        [SDKProperty("desktop_resource_spec_code", IsQuery = true)]
        [JsonProperty("desktop_resource_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopResourceSpecCode { get; set; }

        /// <summary>
        /// 小时包的资源规格编码。
        /// </summary>
        [SDKProperty("resource_spec_code", IsQuery = true)]
        [JsonProperty("resource_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceSpecCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListHourPackagesTypeRequest {\n");
            sb.Append("  desktopResourceSpecCode: ").Append(DesktopResourceSpecCode).Append("\n");
            sb.Append("  resourceSpecCode: ").Append(ResourceSpecCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListHourPackagesTypeRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListHourPackagesTypeRequest input)
        {
            if (input == null) return false;
            if (this.DesktopResourceSpecCode != input.DesktopResourceSpecCode || (this.DesktopResourceSpecCode != null && !this.DesktopResourceSpecCode.Equals(input.DesktopResourceSpecCode))) return false;
            if (this.ResourceSpecCode != input.ResourceSpecCode || (this.ResourceSpecCode != null && !this.ResourceSpecCode.Equals(input.ResourceSpecCode))) return false;

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
                if (this.DesktopResourceSpecCode != null) hashCode = hashCode * 59 + this.DesktopResourceSpecCode.GetHashCode();
                if (this.ResourceSpecCode != null) hashCode = hashCode * 59 + this.ResourceSpecCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
