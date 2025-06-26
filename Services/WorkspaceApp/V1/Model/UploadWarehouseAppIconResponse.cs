using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UploadWarehouseAppIconResponse : SdkResponse
    {

        /// <summary>
        /// 图标文件在obs桶经过cdn加速以后的地址。
        /// </summary>
        [JsonProperty("appicon_store_path", NullValueHandling = NullValueHandling.Ignore)]
        public string AppiconStorePath { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadWarehouseAppIconResponse {\n");
            sb.Append("  appiconStorePath: ").Append(AppiconStorePath).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UploadWarehouseAppIconResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UploadWarehouseAppIconResponse input)
        {
            if (input == null) return false;
            if (this.AppiconStorePath != input.AppiconStorePath || (this.AppiconStorePath != null && !this.AppiconStorePath.Equals(input.AppiconStorePath))) return false;

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
                if (this.AppiconStorePath != null) hashCode = hashCode * 59 + this.AppiconStorePath.GetHashCode();
                return hashCode;
            }
        }
    }
}
