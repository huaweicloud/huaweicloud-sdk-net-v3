using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ModifyPortRequestBody 
    {

        /// <summary>
        /// 新端口号。端口有效范围为2100~9500，暂不支持8636、8637和8638。GeminiDB Mongo副本集4.0数据库实例端口有效范围为2100~9500，暂不支持8636、8637和8638。 GeminiDB Cassandra数据库实例端口有效范围为2100~9500，暂不支持7000，7001，7199，8636，8479，8484，8999，8018，2180，2887，3887，8079，8091，8092。 GeminiDB Redis数据库实例端口有效范围为1024~65535，暂不支持2180、2887、3887、6377、6378、6380、8018、8079、8091、8479、8484、8999、12017、12333、50069。
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public int? Port { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyPortRequestBody {\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyPortRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyPortRequestBody input)
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
