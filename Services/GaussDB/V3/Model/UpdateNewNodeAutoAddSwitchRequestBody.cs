using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 开启或关闭新增节点自动加入该Proxy请求体。
    /// </summary>
    public class UpdateNewNodeAutoAddSwitchRequestBody 
    {

        /// <summary>
        /// 是否开启新增节点自动加入该Proxy。  取值范围： - ON：开启。 - OFF：关闭。
        /// </summary>
        [JsonProperty("switch_status", NullValueHandling = NullValueHandling.Ignore)]
        public string SwitchStatus { get; set; }

        /// <summary>
        /// 新增节点的读权重：  - 新增节点自动加入为ON，取值为0~1000。 - 新增节点自动加入为OFF，则可不输入读权重。
        /// </summary>
        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public int? Weight { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateNewNodeAutoAddSwitchRequestBody {\n");
            sb.Append("  switchStatus: ").Append(SwitchStatus).Append("\n");
            sb.Append("  weight: ").Append(Weight).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateNewNodeAutoAddSwitchRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateNewNodeAutoAddSwitchRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SwitchStatus == input.SwitchStatus ||
                    (this.SwitchStatus != null &&
                    this.SwitchStatus.Equals(input.SwitchStatus))
                ) && 
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
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
                if (this.SwitchStatus != null)
                    hashCode = hashCode * 59 + this.SwitchStatus.GetHashCode();
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
                return hashCode;
            }
        }
    }
}
