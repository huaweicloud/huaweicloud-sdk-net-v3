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
    /// 修改读写分离端口号请求体。
    /// </summary>
    public class UpdateProxyPortRequestBody 
    {

        /// <summary>
        /// 修改后的读写分离端口。  GaussDB(for MySQL) Proxy端口号范围：大于等于1025，小于等于65534，不包含端口1033、5342-5345、12017、20000、20201、20202、33062、33071。
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public int? Port { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateProxyPortRequestBody {\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateProxyPortRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateProxyPortRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
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
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                return hashCode;
            }
        }
    }
}
