using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class AddRdsNoAgentDatabaseResponse : SdkResponse
    {

        /// <summary>
        /// 添加失败的数据库实例id
        /// </summary>
        [JsonProperty("illegal_db_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IllegalDbId { get; set; }

        /// <summary>
        /// 添加成功的数据库实例id
        /// </summary>
        [JsonProperty("legal_db_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LegalDbId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddRdsNoAgentDatabaseResponse {\n");
            sb.Append("  illegalDbId: ").Append(IllegalDbId).Append("\n");
            sb.Append("  legalDbId: ").Append(LegalDbId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddRdsNoAgentDatabaseResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddRdsNoAgentDatabaseResponse input)
        {
            if (input == null) return false;
            if (this.IllegalDbId != input.IllegalDbId || (this.IllegalDbId != null && input.IllegalDbId != null && !this.IllegalDbId.SequenceEqual(input.IllegalDbId))) return false;
            if (this.LegalDbId != input.LegalDbId || (this.LegalDbId != null && input.LegalDbId != null && !this.LegalDbId.SequenceEqual(input.LegalDbId))) return false;

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
                if (this.IllegalDbId != null) hashCode = hashCode * 59 + this.IllegalDbId.GetHashCode();
                if (this.LegalDbId != null) hashCode = hashCode * 59 + this.LegalDbId.GetHashCode();
                return hashCode;
            }
        }
    }
}
