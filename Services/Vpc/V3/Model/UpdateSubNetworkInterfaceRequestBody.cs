using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V3.Model
{
    /// <summary>
    /// This is a auto create Body Object
    /// </summary>
    public class UpdateSubNetworkInterfaceRequestBody 
    {

        /// <summary>
        /// 功能说明：是否只预检此次请求 取值范围： -true：发送检查请求，不会更新辅助弹性网卡。检查项包括是否填写了必需参数、请求格式、业务限制。如果检查不通过，则返回对应错误。如果检查通过，则返回响应码202。 -false（默认值）：发送正常请求，并直接更新辅助弹性网卡。
        /// </summary>
        [JsonProperty("dry_run", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sub_network_interface", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateSubNetworkInterfaceOption SubNetworkInterface { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSubNetworkInterfaceRequestBody {\n");
            sb.Append("  dryRun: ").Append(DryRun).Append("\n");
            sb.Append("  subNetworkInterface: ").Append(SubNetworkInterface).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateSubNetworkInterfaceRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateSubNetworkInterfaceRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DryRun == input.DryRun ||
                    (this.DryRun != null &&
                    this.DryRun.Equals(input.DryRun))
                ) && 
                (
                    this.SubNetworkInterface == input.SubNetworkInterface ||
                    (this.SubNetworkInterface != null &&
                    this.SubNetworkInterface.Equals(input.SubNetworkInterface))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DryRun != null)
                    hashCode = hashCode * 59 + this.DryRun.GetHashCode();
                if (this.SubNetworkInterface != null)
                    hashCode = hashCode * 59 + this.SubNetworkInterface.GetHashCode();
                return hashCode;
            }
        }
    }
}
