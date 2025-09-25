using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ExternalKeyMessage 
    {

        /// <summary>
        /// 第三方保存在代码托管的关键信息
        /// </summary>
        [JsonProperty("external_key_message", NullValueHandling = NullValueHandling.Ignore)]
        public string _ExternalKeyMessage { get; set; }

        /// <summary>
        /// 外部服务名称
        /// </summary>
        [JsonProperty("external_service", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalService { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalKeyMessage {\n");
            sb.Append("  _externalKeyMessage: ").Append(_ExternalKeyMessage).Append("\n");
            sb.Append("  externalService: ").Append(ExternalService).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExternalKeyMessage);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExternalKeyMessage input)
        {
            if (input == null) return false;
            if (this._ExternalKeyMessage != input._ExternalKeyMessage || (this._ExternalKeyMessage != null && !this._ExternalKeyMessage.Equals(input._ExternalKeyMessage))) return false;
            if (this.ExternalService != input.ExternalService || (this.ExternalService != null && !this.ExternalService.Equals(input.ExternalService))) return false;

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
                if (this._ExternalKeyMessage != null) hashCode = hashCode * 59 + this._ExternalKeyMessage.GetHashCode();
                if (this.ExternalService != null) hashCode = hashCode * 59 + this.ExternalService.GetHashCode();
                return hashCode;
            }
        }
    }
}
