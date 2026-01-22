using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ScanProtocolConfig 
    {

        /// <summary>
        /// 反病毒动作，0：观察 1：拦截 2：禁用
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public int? Action { get; set; }

        /// <summary>
        /// 协议类型，包括0：HTTP、1：SMTP、2： POP3、3：IMAP4、4：FTP、5：SMB、6：恶意访问、7：IM
        /// </summary>
        [JsonProperty("protocol_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProtocolType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScanProtocolConfig {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  protocolType: ").Append(ProtocolType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScanProtocolConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScanProtocolConfig input)
        {
            if (input == null) return false;
            if (this.Action != input.Action || (this.Action != null && !this.Action.Equals(input.Action))) return false;
            if (this.ProtocolType != input.ProtocolType || (this.ProtocolType != null && !this.ProtocolType.Equals(input.ProtocolType))) return false;

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
                if (this.Action != null) hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.ProtocolType != null) hashCode = hashCode * 59 + this.ProtocolType.GetHashCode();
                return hashCode;
            }
        }
    }
}
