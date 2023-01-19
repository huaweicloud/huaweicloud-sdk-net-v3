using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpcep.V1.Model
{
    /// <summary>
    /// 当修改终端节点子网路由表失败时，返回错误提示信息
    /// </summary>
    public class RoutetableInfoError 
    {

        /// <summary>
        /// 绑定终端节点子网路由表失败信息。
        /// </summary>
        [JsonProperty("bind_failed", NullValueHandling = NullValueHandling.Ignore)]
        public List<RoutetableInfoErrorDetial> BindFailed { get; set; }

        /// <summary>
        /// 解绑终端节点子网路由表失败信息。
        /// </summary>
        [JsonProperty("unbind_failed", NullValueHandling = NullValueHandling.Ignore)]
        public List<RoutetableInfoErrorDetial> UnbindFailed { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoutetableInfoError {\n");
            sb.Append("  bindFailed: ").Append(BindFailed).Append("\n");
            sb.Append("  unbindFailed: ").Append(UnbindFailed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RoutetableInfoError);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RoutetableInfoError input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BindFailed == input.BindFailed ||
                    this.BindFailed != null &&
                    input.BindFailed != null &&
                    this.BindFailed.SequenceEqual(input.BindFailed)
                ) && 
                (
                    this.UnbindFailed == input.UnbindFailed ||
                    this.UnbindFailed != null &&
                    input.UnbindFailed != null &&
                    this.UnbindFailed.SequenceEqual(input.UnbindFailed)
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
                if (this.BindFailed != null)
                    hashCode = hashCode * 59 + this.BindFailed.GetHashCode();
                if (this.UnbindFailed != null)
                    hashCode = hashCode * 59 + this.UnbindFailed.GetHashCode();
                return hashCode;
            }
        }
    }
}
