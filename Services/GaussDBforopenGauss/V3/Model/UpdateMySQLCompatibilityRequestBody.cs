using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateMySQLCompatibilityRequestBody 
    {

        /// <summary>
        /// M兼容端口，可选范围为：0, 1024-39989。   - 如下端口不可设置： 2378，2379，2380，2400，4999，5000，5001，5100，5500，5999，6000，6001，6009，6010，6500，8015，8097，8098，8181，9090，9100，9180，9187，9200，12016，12017，20049，20050，21731，21732，32122，32123，32124，32125，32126，39001，[数据库端口, 数据库端口+10]。   - 取值为0，表示关闭M兼容端口。
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public string Port { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateMySQLCompatibilityRequestBody {\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateMySQLCompatibilityRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateMySQLCompatibilityRequestBody input)
        {
            if (input == null) return false;
            if (this.Port != input.Port || (this.Port != null && !this.Port.Equals(input.Port))) return false;

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
                if (this.Port != null) hashCode = hashCode * 59 + this.Port.GetHashCode();
                return hashCode;
            }
        }
    }
}
