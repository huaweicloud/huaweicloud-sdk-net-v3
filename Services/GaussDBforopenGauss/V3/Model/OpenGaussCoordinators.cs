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
    /// CN横向扩容时必填
    /// </summary>
    public class OpenGaussCoordinators 
    {

        /// <summary>
        /// 新增CN横向扩容每个节点的可用区。如果需要扩容多个CN，请分别填写待扩容CN所在的可用区。  不同区域的可用区请参考[地区和终端节点](https://developer.huaweicloud.com/endpoint)。  说明： 扩容后，实例中CN节点的数量必须小于或等于两倍的分片数量。
        /// </summary>
        [JsonProperty("az_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AzCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpenGaussCoordinators {\n");
            sb.Append("  azCode: ").Append(AzCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OpenGaussCoordinators);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OpenGaussCoordinators input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AzCode == input.AzCode ||
                    (this.AzCode != null &&
                    this.AzCode.Equals(input.AzCode))
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
                if (this.AzCode != null)
                    hashCode = hashCode * 59 + this.AzCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
