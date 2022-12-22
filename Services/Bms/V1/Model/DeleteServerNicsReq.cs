using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bms.V1.Model
{
    /// <summary>
    /// 需要解绑的网卡列表信息
    /// </summary>
    public class DeleteServerNicsReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("nics", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServerNics> Nics { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteServerNicsReq {\n");
            sb.Append("  nics: ").Append(Nics).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteServerNicsReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteServerNicsReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Nics == input.Nics ||
                    this.Nics != null &&
                    input.Nics != null &&
                    this.Nics.SequenceEqual(input.Nics)
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
                if (this.Nics != null)
                    hashCode = hashCode * 59 + this.Nics.GetHashCode();
                return hashCode;
            }
        }
    }
}
