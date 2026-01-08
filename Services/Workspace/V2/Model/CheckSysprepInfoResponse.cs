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
    public class CheckSysprepInfoResponse : SdkResponse
    {

        /// <summary>
        /// 桌面Sysprep信息。
        /// </summary>
        [JsonProperty("sysprep_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<DesktopSysprepInfo> SysprepInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckSysprepInfoResponse {\n");
            sb.Append("  sysprepInfos: ").Append(SysprepInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckSysprepInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckSysprepInfoResponse input)
        {
            if (input == null) return false;
            if (this.SysprepInfos != input.SysprepInfos || (this.SysprepInfos != null && input.SysprepInfos != null && !this.SysprepInfos.SequenceEqual(input.SysprepInfos))) return false;

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
                if (this.SysprepInfos != null) hashCode = hashCode * 59 + this.SysprepInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
