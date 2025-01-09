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
    /// Response Object
    /// </summary>
    public class ShowSysprepInfoResponse : SdkResponse
    {

        /// <summary>
        /// sysprep版本。
        /// </summary>
        [JsonProperty("sysprep_version", NullValueHandling = NullValueHandling.Ignore)]
        public string SysprepVersion { get; set; }

        /// <summary>
        /// 是否支持创建镜像。
        /// </summary>
        [JsonProperty("support_create_image", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportCreateImage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSysprepInfoResponse {\n");
            sb.Append("  sysprepVersion: ").Append(SysprepVersion).Append("\n");
            sb.Append("  supportCreateImage: ").Append(SupportCreateImage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSysprepInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSysprepInfoResponse input)
        {
            if (input == null) return false;
            if (this.SysprepVersion != input.SysprepVersion || (this.SysprepVersion != null && !this.SysprepVersion.Equals(input.SysprepVersion))) return false;
            if (this.SupportCreateImage != input.SupportCreateImage || (this.SupportCreateImage != null && !this.SupportCreateImage.Equals(input.SupportCreateImage))) return false;

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
                if (this.SysprepVersion != null) hashCode = hashCode * 59 + this.SysprepVersion.GetHashCode();
                if (this.SupportCreateImage != null) hashCode = hashCode * 59 + this.SupportCreateImage.GetHashCode();
                return hashCode;
            }
        }
    }
}
