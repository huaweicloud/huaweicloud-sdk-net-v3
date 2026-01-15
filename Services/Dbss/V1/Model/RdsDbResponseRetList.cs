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
    /// 
    /// </summary>
    public class RdsDbResponseRetList 
    {

        /// <summary>
        /// rds数据库id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 状态 - SUCCESS：成功 - FAILED：失败
        /// </summary>
        [JsonProperty("ret_status", NullValueHandling = NullValueHandling.Ignore)]
        public string RetStatus { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("ret_message", NullValueHandling = NullValueHandling.Ignore)]
        public string RetMessage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RdsDbResponseRetList {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  retStatus: ").Append(RetStatus).Append("\n");
            sb.Append("  retMessage: ").Append(RetMessage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RdsDbResponseRetList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RdsDbResponseRetList input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.RetStatus != input.RetStatus || (this.RetStatus != null && !this.RetStatus.Equals(input.RetStatus))) return false;
            if (this.RetMessage != input.RetMessage || (this.RetMessage != null && !this.RetMessage.Equals(input.RetMessage))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.RetStatus != null) hashCode = hashCode * 59 + this.RetStatus.GetHashCode();
                if (this.RetMessage != null) hashCode = hashCode * 59 + this.RetMessage.GetHashCode();
                return hashCode;
            }
        }
    }
}
