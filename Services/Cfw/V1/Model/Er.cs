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
    public class Er 
    {

        /// <summary>
        /// ER ID
        /// </summary>
        [JsonProperty("er_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ErId { get; set; }

        /// <summary>
        /// ER连接ID
        /// </summary>
        [JsonProperty("er_attach_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ErAttachId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Er {\n");
            sb.Append("  erId: ").Append(ErId).Append("\n");
            sb.Append("  erAttachId: ").Append(ErAttachId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Er);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Er input)
        {
            if (input == null) return false;
            if (this.ErId != input.ErId || (this.ErId != null && !this.ErId.Equals(input.ErId))) return false;
            if (this.ErAttachId != input.ErAttachId || (this.ErAttachId != null && !this.ErAttachId.Equals(input.ErAttachId))) return false;

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
                if (this.ErId != null) hashCode = hashCode * 59 + this.ErId.GetHashCode();
                if (this.ErAttachId != null) hashCode = hashCode * 59 + this.ErAttachId.GetHashCode();
                return hashCode;
            }
        }
    }
}
