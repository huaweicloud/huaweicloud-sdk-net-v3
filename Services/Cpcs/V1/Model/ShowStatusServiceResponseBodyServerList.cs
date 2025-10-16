using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cpcs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ShowStatusServiceResponseBodyServerList 
    {

        /// <summary>
        /// 服务类型
        /// </summary>
        [JsonProperty("server_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerType { get; set; }

        /// <summary>
        /// 应用列表
        /// </summary>
        [JsonProperty("app_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowStatusAppItem> AppList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowStatusServiceResponseBodyServerList {\n");
            sb.Append("  serverType: ").Append(ServerType).Append("\n");
            sb.Append("  appList: ").Append(AppList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowStatusServiceResponseBodyServerList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowStatusServiceResponseBodyServerList input)
        {
            if (input == null) return false;
            if (this.ServerType != input.ServerType || (this.ServerType != null && !this.ServerType.Equals(input.ServerType))) return false;
            if (this.AppList != input.AppList || (this.AppList != null && input.AppList != null && !this.AppList.SequenceEqual(input.AppList))) return false;

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
                if (this.ServerType != null) hashCode = hashCode * 59 + this.ServerType.GetHashCode();
                if (this.AppList != null) hashCode = hashCode * 59 + this.AppList.GetHashCode();
                return hashCode;
            }
        }
    }
}
