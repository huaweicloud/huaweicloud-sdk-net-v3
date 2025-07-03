using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListAppsResponse : SdkResponse
    {

        /// <summary>
        /// 组件信息列表。
        /// </summary>
        [JsonProperty("apps", NullValueHandling = NullValueHandling.Ignore)]
        public List<AppNodeModel> Apps { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAppsResponse {\n");
            sb.Append("  apps: ").Append(Apps).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAppsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAppsResponse input)
        {
            if (input == null) return false;
            if (this.Apps != input.Apps || (this.Apps != null && input.Apps != null && !this.Apps.SequenceEqual(input.Apps))) return false;

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
                if (this.Apps != null) hashCode = hashCode * 59 + this.Apps.GetHashCode();
                return hashCode;
            }
        }
    }
}
