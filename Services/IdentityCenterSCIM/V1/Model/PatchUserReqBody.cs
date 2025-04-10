using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterSCIM.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PatchUserReqBody 
    {

        /// <summary>
        /// 概要
        /// </summary>
        [JsonProperty("schemas", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Schemas { get; set; }

        /// <summary>
        /// 要执行的修改操作列表
        /// </summary>
        [JsonProperty("Operations", NullValueHandling = NullValueHandling.Ignore)]
        public List<OperationItemDto> Operations { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatchUserReqBody {\n");
            sb.Append("  schemas: ").Append(Schemas).Append("\n");
            sb.Append("  operations: ").Append(Operations).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PatchUserReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PatchUserReqBody input)
        {
            if (input == null) return false;
            if (this.Schemas != input.Schemas || (this.Schemas != null && input.Schemas != null && !this.Schemas.SequenceEqual(input.Schemas))) return false;
            if (this.Operations != input.Operations || (this.Operations != null && input.Operations != null && !this.Operations.SequenceEqual(input.Operations))) return false;

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
                if (this.Schemas != null) hashCode = hashCode * 59 + this.Schemas.GetHashCode();
                if (this.Operations != null) hashCode = hashCode * 59 + this.Operations.GetHashCode();
                return hashCode;
            }
        }
    }
}
