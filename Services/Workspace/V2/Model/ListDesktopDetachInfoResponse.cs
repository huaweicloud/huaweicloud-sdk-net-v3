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
    public class ListDesktopDetachInfoResponse : SdkResponse
    {

        /// <summary>
        /// 桌面解绑信息。
        /// </summary>
        [JsonProperty("desktop_detach_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<DesktopDetachInfo> DesktopDetachInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDesktopDetachInfoResponse {\n");
            sb.Append("  desktopDetachInfos: ").Append(DesktopDetachInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDesktopDetachInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDesktopDetachInfoResponse input)
        {
            if (input == null) return false;
            if (this.DesktopDetachInfos != input.DesktopDetachInfos || (this.DesktopDetachInfos != null && input.DesktopDetachInfos != null && !this.DesktopDetachInfos.SequenceEqual(input.DesktopDetachInfos))) return false;

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
                if (this.DesktopDetachInfos != null) hashCode = hashCode * 59 + this.DesktopDetachInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
