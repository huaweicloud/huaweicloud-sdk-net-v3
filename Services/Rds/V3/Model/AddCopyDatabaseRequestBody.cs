using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AddCopyDatabaseRequestBody 
    {

        /// <summary>
        /// 操作名称(copy_database)
        /// </summary>
        [JsonProperty("procedure_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProcedureName { get; set; }

        /// <summary>
        /// 源库和目的库信息
        /// </summary>
        [JsonProperty("params", NullValueHandling = NullValueHandling.Ignore)]
        public Object Params { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddCopyDatabaseRequestBody {\n");
            sb.Append("  procedureName: ").Append(ProcedureName).Append("\n");
            sb.Append("  Params: ").Append(Params).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddCopyDatabaseRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddCopyDatabaseRequestBody input)
        {
            if (input == null) return false;
            if (this.ProcedureName != input.ProcedureName || (this.ProcedureName != null && !this.ProcedureName.Equals(input.ProcedureName))) return false;
            if (this.Params != input.Params || (this.Params != null && !this.Params.Equals(input.Params))) return false;

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
                if (this.ProcedureName != null) hashCode = hashCode * 59 + this.ProcedureName.GetHashCode();
                if (this.Params != null) hashCode = hashCode * 59 + this.Params.GetHashCode();
                return hashCode;
            }
        }
    }
}
