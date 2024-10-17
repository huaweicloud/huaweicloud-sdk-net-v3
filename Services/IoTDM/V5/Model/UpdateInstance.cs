using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDM.V5.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateInstance 
    {

        /// <summary>
        /// **参数说明**：实例名称 **取值范围**：由中文字符，英文字母、数字及“_”、“-”组成，且长度为[1-64]个字符。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数说明**：设备接入实例的描述信息。 **取值范围**：由中文，字母，数字，句号，逗号，下划线（“_”），中划线（“-”），空格组成，且长度为[1-256]个字符。 
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("operate_window", NullValueHandling = NullValueHandling.Ignore)]
        public OperateWindow OperateWindow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("forwarding_info", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateForwardingInfo ForwardingInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("access_info", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateAccessInfo AccessInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateInstance {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  operateWindow: ").Append(OperateWindow).Append("\n");
            sb.Append("  forwardingInfo: ").Append(ForwardingInfo).Append("\n");
            sb.Append("  accessInfo: ").Append(AccessInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateInstance);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateInstance input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.OperateWindow != input.OperateWindow || (this.OperateWindow != null && !this.OperateWindow.Equals(input.OperateWindow))) return false;
            if (this.ForwardingInfo != input.ForwardingInfo || (this.ForwardingInfo != null && !this.ForwardingInfo.Equals(input.ForwardingInfo))) return false;
            if (this.AccessInfo != input.AccessInfo || (this.AccessInfo != null && !this.AccessInfo.Equals(input.AccessInfo))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.OperateWindow != null) hashCode = hashCode * 59 + this.OperateWindow.GetHashCode();
                if (this.ForwardingInfo != null) hashCode = hashCode * 59 + this.ForwardingInfo.GetHashCode();
                if (this.AccessInfo != null) hashCode = hashCode * 59 + this.AccessInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
