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
    /// 驱动接口重定向。
    /// </summary>
    public class PoliciesPeripheralsDriverInterfaceRedirection 
    {

        /// <summary>
        /// 自定义驱动列表。（填写安装在终端的驱动文件名或驱动文件的全路径，支持配置多个，多个之间以\&quot;;\&quot;隔开）。
        /// </summary>
        [JsonProperty("api_redir_driver_list", NullValueHandling = NullValueHandling.Ignore)]
        public string ApiRedirDriverList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesPeripheralsDriverInterfaceRedirection {\n");
            sb.Append("  apiRedirDriverList: ").Append(ApiRedirDriverList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesPeripheralsDriverInterfaceRedirection);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesPeripheralsDriverInterfaceRedirection input)
        {
            if (input == null) return false;
            if (this.ApiRedirDriverList != input.ApiRedirDriverList || (this.ApiRedirDriverList != null && !this.ApiRedirDriverList.Equals(input.ApiRedirDriverList))) return false;

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
                if (this.ApiRedirDriverList != null) hashCode = hashCode * 59 + this.ApiRedirDriverList.GetHashCode();
                return hashCode;
            }
        }
    }
}
