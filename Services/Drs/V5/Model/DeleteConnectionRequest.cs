using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteConnectionRequest 
    {

        /// <summary>
        /// 连接ID。
        /// </summary>
        [SDKProperty("connection_id", IsPath = true)]
        [JsonProperty("connection_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectionId { get; set; }

        /// <summary>
        /// 请求语言类型。
        /// </summary>
        [SDKProperty("X-Language", IsHeader = true)]
        [JsonProperty("X-Language", NullValueHandling = NullValueHandling.Ignore)]
        public string XLanguage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteConnectionRequest {\n");
            sb.Append("  connectionId: ").Append(ConnectionId).Append("\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteConnectionRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteConnectionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConnectionId == input.ConnectionId ||
                    (this.ConnectionId != null &&
                    this.ConnectionId.Equals(input.ConnectionId))
                ) && 
                (
                    this.XLanguage == input.XLanguage ||
                    (this.XLanguage != null &&
                    this.XLanguage.Equals(input.XLanguage))
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
                if (this.ConnectionId != null)
                    hashCode = hashCode * 59 + this.ConnectionId.GetHashCode();
                if (this.XLanguage != null)
                    hashCode = hashCode * 59 + this.XLanguage.GetHashCode();
                return hashCode;
            }
        }
    }
}
