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
    public class BatchDeleteDomainSetsDto 
    {

        /// <summary>
        /// 防护对象id
        /// </summary>
        [JsonProperty("object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectId { get; set; }

        /// <summary>
        /// 域名组id
        /// </summary>
        [JsonProperty("set_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SetIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteDomainSetsDto {\n");
            sb.Append("  objectId: ").Append(ObjectId).Append("\n");
            sb.Append("  setIds: ").Append(SetIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteDomainSetsDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteDomainSetsDto input)
        {
            if (input == null) return false;
            if (this.ObjectId != input.ObjectId || (this.ObjectId != null && !this.ObjectId.Equals(input.ObjectId))) return false;
            if (this.SetIds != input.SetIds || (this.SetIds != null && input.SetIds != null && !this.SetIds.SequenceEqual(input.SetIds))) return false;

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
                if (this.ObjectId != null) hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                if (this.SetIds != null) hashCode = hashCode * 59 + this.SetIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
