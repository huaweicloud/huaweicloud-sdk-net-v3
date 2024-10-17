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
    /// 端口信息。
    /// </summary>
    public class ChInstancesInfoRsponseInstancePortInfo 
    {

        /// <summary>
        /// tep端口。取值范围：0~65535。
        /// </summary>
        [JsonProperty("tep_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? TepPort { get; set; }

        /// <summary>
        /// http端口。取值范围：0~65535。
        /// </summary>
        [JsonProperty("http_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? HttpPort { get; set; }

        /// <summary>
        /// MySql端口号。取值范围：0~65535。
        /// </summary>
        [JsonProperty("mysql_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? MysqlPort { get; set; }

        /// <summary>
        /// https端口号。取值范围：0~65535。
        /// </summary>
        [JsonProperty("https_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? HttpsPort { get; set; }

        /// <summary>
        /// tep安全端口。取值范围：0~65535。
        /// </summary>
        [JsonProperty("tep_secure_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? TepSecurePort { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChInstancesInfoRsponseInstancePortInfo {\n");
            sb.Append("  tepPort: ").Append(TepPort).Append("\n");
            sb.Append("  httpPort: ").Append(HttpPort).Append("\n");
            sb.Append("  mysqlPort: ").Append(MysqlPort).Append("\n");
            sb.Append("  httpsPort: ").Append(HttpsPort).Append("\n");
            sb.Append("  tepSecurePort: ").Append(TepSecurePort).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChInstancesInfoRsponseInstancePortInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChInstancesInfoRsponseInstancePortInfo input)
        {
            if (input == null) return false;
            if (this.TepPort != input.TepPort || (this.TepPort != null && !this.TepPort.Equals(input.TepPort))) return false;
            if (this.HttpPort != input.HttpPort || (this.HttpPort != null && !this.HttpPort.Equals(input.HttpPort))) return false;
            if (this.MysqlPort != input.MysqlPort || (this.MysqlPort != null && !this.MysqlPort.Equals(input.MysqlPort))) return false;
            if (this.HttpsPort != input.HttpsPort || (this.HttpsPort != null && !this.HttpsPort.Equals(input.HttpsPort))) return false;
            if (this.TepSecurePort != input.TepSecurePort || (this.TepSecurePort != null && !this.TepSecurePort.Equals(input.TepSecurePort))) return false;

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
                if (this.TepPort != null) hashCode = hashCode * 59 + this.TepPort.GetHashCode();
                if (this.HttpPort != null) hashCode = hashCode * 59 + this.HttpPort.GetHashCode();
                if (this.MysqlPort != null) hashCode = hashCode * 59 + this.MysqlPort.GetHashCode();
                if (this.HttpsPort != null) hashCode = hashCode * 59 + this.HttpsPort.GetHashCode();
                if (this.TepSecurePort != null) hashCode = hashCode * 59 + this.TepSecurePort.GetHashCode();
                return hashCode;
            }
        }
    }
}
